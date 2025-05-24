using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Xml.Serialization;

namespace RPGCharacterPrototype
{
    public partial class MainForm : Form
    {
        private List<Character> characters;
        private const string JSON_FILE_PATH = "characters.json";
        private const string XML_FILE_PATH = "characters.xml";

        public MainForm()
        {
            InitializeComponent();
            // Ініціалізуємо пустий список персонажів (без автоматичного завантаження)
            characters = new List<Character>();
            RefreshCharactersList();
        }

        // Метод для оновлення списку персонажів
        private void RefreshCharactersList()
        {
            lstCharacters.Items.Clear();
            foreach (var character in characters)
            {
                lstCharacters.Items.Add(character);
            }
        }

        // Обробник події натискання кнопки "Створити персонажа"
        private void btnCreateCharacter_Click(object sender, EventArgs e)
        {
            // Створюємо новий екземпляр форми редагування персонажа
            CharacterEditForm editForm = new CharacterEditForm();

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                // Додаємо створеного персонажа до списку
                Character newCharacter = editForm.Character;
                characters.Add(newCharacter);
                RefreshCharactersList();
            }
        }

        // Обробник події натискання кнопки "Клонувати персонажа"
        private void btnCloneCharacter_Click(object sender, EventArgs e)
        {
            if (lstCharacters.SelectedItem == null)
            {
                MessageBox.Show("Будь ласка, виберіть персонажа для клонування!", "Попередження",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Клонуємо вибраного персонажа
            Character selectedCharacter = lstCharacters.SelectedItem as Character;
            Character clonedCharacter = selectedCharacter.Clone() as Character;

            // Додаємо клонованого персонажа до списку
            characters.Add(clonedCharacter);
            RefreshCharactersList();

            // Вибираємо клонованого персонажа у списку
            lstCharacters.SelectedItem = clonedCharacter;
        }

        // Обробник події натискання кнопки "Редагувати персонажа"
        private void btnEditCharacter_Click(object sender, EventArgs e)
        {
            if (lstCharacters.SelectedItem == null)
            {
                MessageBox.Show("Будь ласка, виберіть персонажа для редагування!", "Попередження",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Отримуємо вибраного персонажа
            Character selectedCharacter = lstCharacters.SelectedItem as Character;
            int index = characters.IndexOf(selectedCharacter);

            // Створюємо новий екземпляр форми редагування персонажа
            CharacterEditForm editForm = new CharacterEditForm(selectedCharacter);

            if (editForm.ShowDialog() == DialogResult.OK)
            {
                // Оновлюємо персонажа у списку
                characters[index] = editForm.Character;
                RefreshCharactersList();
                lstCharacters.SelectedIndex = index;
            }
        }

        // Обробник події натискання кнопки "Видалити персонажа"
        private void btnDeleteCharacter_Click(object sender, EventArgs e)
        {
            if (lstCharacters.SelectedItem == null)
            {
                MessageBox.Show("Будь ласка, виберіть персонажа для видалення!", "Попередження",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Запитуємо підтвердження видалення
            Character selectedCharacter = lstCharacters.SelectedItem as Character;
            DialogResult result = MessageBox.Show($"Ви дійсно бажаєте видалити персонажа '{selectedCharacter.Name}'?",
                "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Видаляємо персонажа зі списку
                characters.Remove(selectedCharacter);
                RefreshCharactersList();
            }
        }

        // Метод для збереження персонажів у JSON форматі
        private void SaveToJson()
        {
            try
            {
                // Налаштування серіалізації JSON
                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                };

                // Серіалізуємо список персонажів у JSON
                string jsonString = JsonSerializer.Serialize(characters, options);

                // Записуємо у файл
                File.WriteAllText(JSON_FILE_PATH, jsonString);

                MessageBox.Show("Персонажі успішно збережені у форматі JSON!", "Інформація",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при збереженні персонажів у JSON: {ex.Message}", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Метод для збереження персонажів у XML форматі
        private void SaveToXml()
        {
            try
            {
                // Створюємо XML серіалізатор
                XmlSerializer serializer = new XmlSerializer(typeof(List<Character>));

                // Створюємо файловий потік
                using (FileStream fs = new FileStream(XML_FILE_PATH, FileMode.Create))
                {
                    // Серіалізуємо список персонажів у XML
                    serializer.Serialize(fs, characters);
                }

                MessageBox.Show("Персонажі успішно збережені у форматі XML!", "Інформація",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при збереженні персонажів у XML: {ex.Message}", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обробник події натискання кнопки "Завантажити персонажів"
        private void btnLoadCharacters_Click(object sender, EventArgs e)
        {
            // Створюємо діалог вибору формату завантаження
            DialogResult result = MessageBox.Show("Завантажити з JSON файлу? (Якщо 'Ні', буде використано XML файл)",
                "Вибір формату", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Cancel)
                return;

            try
            {
                if (result == DialogResult.Yes)
                {
                    // Завантажуємо з JSON
                    if (!File.Exists(JSON_FILE_PATH))
                    {
                        MessageBox.Show($"Файл {JSON_FILE_PATH} не знайдено!", "Помилка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string jsonString = File.ReadAllText(JSON_FILE_PATH);

                    // Важливо: використовуємо ті самі налаштування серіалізації, що й при збереженні
                    JsonSerializerOptions options = new JsonSerializerOptions
                    {
                        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                    };

                    characters = JsonSerializer.Deserialize<List<Character>>(jsonString, options);

                    MessageBox.Show("Персонажі успішно завантажені з JSON!", "Інформація",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Завантажуємо з XML
                    if (!File.Exists(XML_FILE_PATH))
                    {
                        MessageBox.Show($"Файл {XML_FILE_PATH} не знайдено!", "Помилка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    XmlSerializer serializer = new XmlSerializer(typeof(List<Character>));
                    using (FileStream fs = new FileStream(XML_FILE_PATH, FileMode.Open))
                    {
                        characters = (List<Character>)serializer.Deserialize(fs);
                    }
                    MessageBox.Show("Персонажі успішно завантажені з XML!", "Інформація",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Оновлюємо список персонажів
                RefreshCharactersList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при завантаженні персонажів: {ex.Message}", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обробник події натискання кнопки "Зберегти в JSON"
        private void btnSaveJson_Click(object sender, EventArgs e)
        {
            SaveToJson();
        }

        // Обробник події натискання кнопки "Зберегти в XML"
        private void btnSaveXml_Click(object sender, EventArgs e)
        {
            SaveToXml();
        }

        // Обробник події завантаження форми
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Встановлюємо іконку та назву вікна
            this.Text = "RPG Character Manager";
            this.Icon = SystemIcons.Application;
        }
    }
}