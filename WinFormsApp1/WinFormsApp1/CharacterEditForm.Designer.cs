using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGCharacterPrototype
{
    public partial class CharacterEditForm : Form
    {
        // Designer-генерований код
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numLevel = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numHealth = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numMana = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.cmbWeapon = new System.Windows.Forms.ComboBox();
            this.cmbArmor = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstAbilities = new System.Windows.Forms.ListBox();
            this.btnAddAbility = new System.Windows.Forms.Button();
            this.btnEditAbility = new System.Windows.Forms.Button();
            this.btnRemoveAbility = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMana)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ім\'я";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(155, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(327, 22);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Рівень";
            // 
            // numLevel
            // 
            this.numLevel.Location = new System.Drawing.Point(155, 41);
            this.numLevel.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLevel.Name = "numLevel";
            this.numLevel.Size = new System.Drawing.Size(120, 22);
            this.numLevel.TabIndex = 3;
            this.numLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Здоров\'я";
            // 
            // numHealth
            // 
            this.numHealth.Location = new System.Drawing.Point(155, 69);
            this.numHealth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numHealth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHealth.Name = "numHealth";
            this.numHealth.Size = new System.Drawing.Size(120, 22);
            this.numHealth.TabIndex = 5;
            this.numHealth.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Мана";
            // 
            // numMana
            // 
            this.numMana.Location = new System.Drawing.Point(155, 97);
            this.numMana.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numMana.Name = "numMana";
            this.numMana.Size = new System.Drawing.Size(120, 22);
            this.numMana.TabIndex = 7;
            this.numMana.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Клас";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Зброя";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Броня";
            // 
            // cmbClass
            // 
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(155, 126);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(231, 24);
            this.cmbClass.TabIndex = 11;
            // 
            // cmbWeapon
            // 
            this.cmbWeapon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWeapon.FormattingEnabled = true;
            this.cmbWeapon.Location = new System.Drawing.Point(155, 156);
            this.cmbWeapon.Name = "cmbWeapon";
            this.cmbWeapon.Size = new System.Drawing.Size(231, 24);
            this.cmbWeapon.TabIndex = 12;
            // 
            // cmbArmor
            // 
            this.cmbArmor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArmor.FormattingEnabled = true;
            this.cmbArmor.Location = new System.Drawing.Point(155, 186);
            this.cmbArmor.Name = "cmbArmor";
            this.cmbArmor.Size = new System.Drawing.Size(231, 24);
            this.cmbArmor.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnRemoveAbility);
            this.groupBox1.Controls.Add(this.btnEditAbility);
            this.groupBox1.Controls.Add(this.btnAddAbility);
            this.groupBox1.Controls.Add(this.lstAbilities);
            this.groupBox1.Location = new System.Drawing.Point(15, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 181);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Здібності";
            // 
            // lstAbilities
            // 
            this.lstAbilities.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstAbilities.FormattingEnabled = true;
            this.lstAbilities.ItemHeight = 16;
            this.lstAbilities.Location = new System.Drawing.Point(6, 21);
            this.lstAbilities.Name = "lstAbilities";
            this.lstAbilities.Size = new System.Drawing.Size(332, 148);
            this.lstAbilities.TabIndex = 0;
            // 
            // btnAddAbility
            // 
            this.btnAddAbility.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAbility.Location = new System.Drawing.Point(344, 21);
            this.btnAddAbility.Name = "btnAddAbility";
            this.btnAddAbility.Size = new System.Drawing.Size(117, 33);
            this.btnAddAbility.TabIndex = 1;
            this.btnAddAbility.Text = "Додати";
            this.btnAddAbility.UseVisualStyleBackColor = true;
            this.btnAddAbility.Click += new System.EventHandler(this.btnAddAbility_Click);
            // 
            // btnEditAbility
            // 
            this.btnEditAbility.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditAbility.Location = new System.Drawing.Point(344, 60);
            this.btnEditAbility.Name = "btnEditAbility";
            this.btnEditAbility.Size = new System.Drawing.Size(117, 33);
            this.btnEditAbility.TabIndex = 2;
            this.btnEditAbility.Text = "Редагувати";
            this.btnEditAbility.UseVisualStyleBackColor = true;
            this.btnEditAbility.Click += new System.EventHandler(this.btnEditAbility_Click);
            // 
            // btnRemoveAbility
            // 
            this.btnRemoveAbility.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveAbility.Location = new System.Drawing.Point(344, 99);
            this.btnRemoveAbility.Name = "btnRemoveAbility";
            this.btnRemoveAbility.Size = new System.Drawing.Size(117, 33);
            this.btnRemoveAbility.TabIndex = 3;
            this.btnRemoveAbility.Text = "Видалити";
            this.btnRemoveAbility.UseVisualStyleBackColor = true;
            this.btnRemoveAbility.Click += new System.EventHandler(this.btnRemoveAbility_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(279, 403);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 35);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Зберегти";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(382, 403);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Скасувати";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CharacterEditForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(494, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbArmor);
            this.Controls.Add(this.cmbWeapon);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numMana);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numHealth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numLevel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(512, 497);
            this.Name = "CharacterEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редагування персонажа";
            this.Load += new System.EventHandler(this.CharacterEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMana)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numLevel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numHealth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numMana;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.ComboBox cmbWeapon;
        private System.Windows.Forms.ComboBox cmbArmor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemoveAbility;
        private System.Windows.Forms.Button btnEditAbility;
        private System.Windows.Forms.Button btnAddAbility;
        private System.Windows.Forms.ListBox lstAbilities;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}