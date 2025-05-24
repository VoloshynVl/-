using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RPGCharacterPrototype
{
    public partial class AbilityEditForm : Form
    {
        // Властивість для доступу до створеної або відредагованої здібності
        public Ability Ability { get; private set; }

        // Конструктор для створення нової здібності
        public AbilityEditForm()
        {
            InitializeComponent();
            this.Text = "Створення нової здібності";

            // Створюємо нову здібність з деякими значеннями за замовчуванням
            Ability = new Ability
            {
                Name = "",
                Description = "",
                ManaCost = 10,
                Cooldown = 1
            };
        }

        // Конструктор для редагування існуючої здібності
        public AbilityEditForm(Ability ability)
        {
            InitializeComponent();
            this.Text = "Редагування здібності";

            // Створюємо копію існуючої здібності для редагування
            Ability = ability.Clone();

            // Заповнюємо поля форми значеннями існуючої здібності
            FillFormWithAbilityData();
        }

        // Метод для заповнення форми даними здібності
        private void FillFormWithAbilityData()
        {
            txtName.Text = Ability.Name;
            txtDescription.Text = Ability.Description;
            numManaCost.Value = Ability.ManaCost;
            numCooldown.Value = Ability.Cooldown;
        }

        // Метод для оновлення даних здібності з форми
        private void UpdateAbilityFromForm()
        {
            Ability.Name = txtName.Text.Trim();
            Ability.Description = txtDescription.Text.Trim();
            Ability.ManaCost = (int)numManaCost.Value;
            Ability.Cooldown = (int)numCooldown.Value;
        }

        // Обробник події натискання кнопки "Зберегти"
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Перевіряємо, чи всі обов'язкові поля заповнені
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Будь ласка, введіть назву здібності!", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }

            // Оновлюємо дані здібності з форми
            UpdateAbilityFromForm();

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

        // Обробник події завантаження форми
        private void AbilityEditForm_Load(object sender, EventArgs e)
        {
            // Встановлюємо іконку вікна
            this.Icon = SystemIcons.Application;
        }
    }
}