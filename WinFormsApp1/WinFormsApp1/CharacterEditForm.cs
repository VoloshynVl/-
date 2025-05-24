using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RPGCharacterPrototype
{
    public partial class CharacterEditForm : Form
    {
        // Властивість для доступу до створеного або відредагованого персонажа
        public Character Character { get; private set; }

        // Конструктор для створення нового персонажа
        public CharacterEditForm()
        {
            InitializeComponent();
            this.Text = "Створення нового персонажа";
            PopulateComboBoxes();

            // Створюємо новий персонаж з деякими значеннями за замовчуванням
            Character = new Character
            {
                Name = "",
                Level = 1,
                Health = 100,
                Mana = 50,
                Abilities = new List<Ability>(),
                Class = CharacterClass.Warrior,
                Weapon = WeaponType.Sword,
                Armor = ArmorType.Medium
            };
        }

        // Конструктор для редагування існуючого персонажа
        public CharacterEditForm(Character character)
        {
            InitializeComponent();
            this.Text = "Редагування персонажа";
            PopulateComboBoxes();

            // Створюємо копію існуючого персонажа для редагування
            Character = character.Clone() as Character;

            // Заповнюємо поля форми значеннями існуючого персонажа
            FillFormWithCharacterData();
        }

        // Метод для заповнення випадаючих списків значеннями з перелічень
        private void PopulateComboBoxes()
        {
            // Заповнюємо ComboBox для класів персонажа
            cmbClass.DataSource = Enum.GetValues(typeof(CharacterClass));

            // Заповнюємо ComboBox для типів зброї
            cmbWeapon.DataSource = Enum.GetValues(typeof(WeaponType));

            // Заповнюємо ComboBox для типів броні
            cmbArmor.DataSource = Enum.GetValues(typeof(ArmorType));
        }

        // Метод для заповнення форми даними персонажа
        private void FillFormWithCharacterData()
        {
            txtName.Text = Character.Name;
            numLevel.Value = Character.Level;
            numHealth.Value = Character.Health;
            numMana.Value = Character.Mana;
            cmbClass.SelectedItem = Character.Class;
            cmbWeapon.SelectedItem = Character.Weapon;
            cmbArmor.SelectedItem = Character.Armor;

            // Заповнюємо список здібностей
            lstAbilities.Items.Clear();
            foreach (var ability in Character.Abilities)
            {
                lstAbilities.Items.Add(ability);
            }
        }

        // Метод для оновлення даних персонажа з форми
        private void UpdateCharacterFromForm()
        {
            Character.Name = txtName.Text.Trim();
            Character.Level = (int)numLevel.Value;
            Character.Health = (int)numHealth.Value;
            Character.Mana = (int)numMana.Value;
            Character.Class = (CharacterClass)cmbClass.SelectedItem;
            Character.Weapon = (WeaponType)cmbWeapon.SelectedItem;
            Character.Armor = (ArmorType)cmbArmor.SelectedItem;

            // Здібності вже оновлені в списку Character.Abilities
        }

        // Обробник події натискання кнопки "Зберегти"
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Перевіряємо, чи всі обов'язкові поля заповнені
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Будь ласка, введіть ім'я персонажа!", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }

            // Оновлюємо дані персонажа з форми
            UpdateCharacterFromForm();

            // Закриваємо форму з результатом OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Обробник події натискання кнопки "Скасувати"
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Обробник події натискання кнопки "Додати здібність"
        private void btnAddAbility_Click(object sender, EventArgs e)
        {
            // Показуємо форму додавання здібності
            AbilityEditForm abilityForm = new AbilityEditForm();

            if (abilityForm.ShowDialog() == DialogResult.OK)
            {
                // Отримуємо нову здібність
                Ability newAbility = abilityForm.Ability;

                // Додаємо здібність до персонажа
                Character.AddAbility(newAbility);

                // Додаємо здібність до списку
                lstAbilities.Items.Add(newAbility);
            }
        }

        // Обробник події натискання кнопки "Редагувати здібність"
        private void btnEditAbility_Click(object sender, EventArgs e)
        {
            if (lstAbilities.SelectedItem == null)
            {
                MessageBox.Show("Будь ласка, виберіть здібність для редагування!", "Попередження",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Отримуємо вибрану здібність
            Ability selectedAbility = lstAbilities.SelectedItem as Ability;
            int index = Character.Abilities.IndexOf(selectedAbility);

            // Показуємо форму редагування здібності
            AbilityEditForm abilityForm = new AbilityEditForm(selectedAbility);

            if (abilityForm.ShowDialog() == DialogResult.OK)
            {
                // Оновлюємо здібність у персонажа
                Character.Abilities[index] = abilityForm.Ability;

                // Оновлюємо список здібностей
                lstAbilities.Items[lstAbilities.SelectedIndex] = abilityForm.Ability;
            }
        }

        // Обробник події натискання кнопки "Видалити здібність"
        private void btnRemoveAbility_Click(object sender, EventArgs e)
        {
            if (lstAbilities.SelectedItem == null)
            {
                MessageBox.Show("Будь ласка, виберіть здібність для видалення!", "Попередження",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Запитуємо підтвердження видалення
            Ability selectedAbility = lstAbilities.SelectedItem as Ability;
            DialogResult result = MessageBox.Show($"Ви дійсно бажаєте видалити здібність '{selectedAbility.Name}'?",
                "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Видаляємо здібність з персонажа
                Character.RemoveAbility(selectedAbility);

                // Видаляємо здібність зі списку
                lstAbilities.Items.RemoveAt(lstAbilities.SelectedIndex);
            }
        }

        // Обробник події завантаження форми
        private void CharacterEditForm_Load(object sender, EventArgs e)
        {
            // Встановлюємо іконку вікна
            this.Icon = SystemIcons.Application;
        }
    }
}