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
    public partial class MainForm : Form
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
            this.lstCharacters = new System.Windows.Forms.ListBox();
            this.btnCreateCharacter = new System.Windows.Forms.Button();
            this.btnCloneCharacter = new System.Windows.Forms.Button();
            this.btnEditCharacter = new System.Windows.Forms.Button();
            this.btnDeleteCharacter = new System.Windows.Forms.Button();
            this.btnSaveJson = new System.Windows.Forms.Button();
            this.btnSaveXml = new System.Windows.Forms.Button();
            this.btnLoadCharacters = new System.Windows.Forms.Button();
            this.lblCharacters = new System.Windows.Forms.Label();
            this.grpActions = new System.Windows.Forms.GroupBox();
            this.grpSave = new System.Windows.Forms.GroupBox();
            this.grpActions.SuspendLayout();
            this.grpSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCharacters
            // 
            this.lstCharacters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstCharacters.FormattingEnabled = true;
            this.lstCharacters.ItemHeight = 16;
            this.lstCharacters.Location = new System.Drawing.Point(12, 36);
            this.lstCharacters.Name = "lstCharacters";
            this.lstCharacters.Size = new System.Drawing.Size(575, 308);
            this.lstCharacters.TabIndex = 0;
            // 
            // btnCreateCharacter
            // 
            this.btnCreateCharacter.Location = new System.Drawing.Point(6, 21);
            this.btnCreateCharacter.Name = "btnCreateCharacter";
            this.btnCreateCharacter.Size = new System.Drawing.Size(184, 35);
            this.btnCreateCharacter.TabIndex = 1;
            this.btnCreateCharacter.Text = "Створити персонажа";
            this.btnCreateCharacter.UseVisualStyleBackColor = true;
            this.btnCreateCharacter.Click += new System.EventHandler(this.btnCreateCharacter_Click);
            // 
            // btnCloneCharacter
            // 
            this.btnCloneCharacter.Location = new System.Drawing.Point(6, 62);
            this.btnCloneCharacter.Name = "btnCloneCharacter";
            this.btnCloneCharacter.Size = new System.Drawing.Size(184, 35);
            this.btnCloneCharacter.TabIndex = 2;
            this.btnCloneCharacter.Text = "Клонувати персонажа";
            this.btnCloneCharacter.UseVisualStyleBackColor = true;
            this.btnCloneCharacter.Click += new System.EventHandler(this.btnCloneCharacter_Click);
            // 
            // btnEditCharacter
            // 
            this.btnEditCharacter.Location = new System.Drawing.Point(6, 103);
            this.btnEditCharacter.Name = "btnEditCharacter";
            this.btnEditCharacter.Size = new System.Drawing.Size(184, 35);
            this.btnEditCharacter.TabIndex = 3;
            this.btnEditCharacter.Text = "Редагувати персонажа";
            this.btnEditCharacter.UseVisualStyleBackColor = true;
            this.btnEditCharacter.Click += new System.EventHandler(this.btnEditCharacter_Click);
            // 
            // btnDeleteCharacter
            // 
            this.btnDeleteCharacter.Location = new System.Drawing.Point(6, 144);
            this.btnDeleteCharacter.Name = "btnDeleteCharacter";
            this.btnDeleteCharacter.Size = new System.Drawing.Size(184, 35);
            this.btnDeleteCharacter.TabIndex = 4;
            this.btnDeleteCharacter.Text = "Видалити персонажа";
            this.btnDeleteCharacter.UseVisualStyleBackColor = true;
            this.btnDeleteCharacter.Click += new System.EventHandler(this.btnDeleteCharacter_Click);
            // 
            // btnSaveJson
            // 
            this.btnSaveJson.Location = new System.Drawing.Point(6, 21);
            this.btnSaveJson.Name = "btnSaveJson";
            this.btnSaveJson.Size = new System.Drawing.Size(184, 35);
            this.btnSaveJson.TabIndex = 5;
            this.btnSaveJson.Text = "Зберегти в JSON";
            this.btnSaveJson.UseVisualStyleBackColor = true;
            this.btnSaveJson.Click += new System.EventHandler(this.btnSaveJson_Click);
            // 
            // btnSaveXml
            // 
            this.btnSaveXml.Location = new System.Drawing.Point(6, 62);
            this.btnSaveXml.Name = "btnSaveXml";
            this.btnSaveXml.Size = new System.Drawing.Size(184, 35);
            this.btnSaveXml.TabIndex = 6;
            this.btnSaveXml.Text = "Зберегти в XML";
            this.btnSaveXml.UseVisualStyleBackColor = true;
            this.btnSaveXml.Click += new System.EventHandler(this.btnSaveXml_Click);
            // 
            // btnLoadCharacters
            // 
            this.btnLoadCharacters.Location = new System.Drawing.Point(6, 103);
            this.btnLoadCharacters.Name = "btnLoadCharacters";
            this.btnLoadCharacters.Size = new System.Drawing.Size(184, 35);
            this.btnLoadCharacters.TabIndex = 7;
            this.btnLoadCharacters.Text = "Завантажити персонажів";
            this.btnLoadCharacters.UseVisualStyleBackColor = true;
            this.btnLoadCharacters.Click += new System.EventHandler(this.btnLoadCharacters_Click);
            // 
            // lblCharacters
            // 
            this.lblCharacters.AutoSize = true;
            this.lblCharacters.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCharacters.Location = new System.Drawing.Point(12, 9);
            this.lblCharacters.Name = "lblCharacters";
            this.lblCharacters.Size = new System.Drawing.Size(145, 16);
            this.lblCharacters.TabIndex = 7;
            this.lblCharacters.Text = "Список персонажів";
            // 
            // grpActions
            // 
            this.grpActions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpActions.Controls.Add(this.btnCreateCharacter);
            this.grpActions.Controls.Add(this.btnCloneCharacter);
            this.grpActions.Controls.Add(this.btnEditCharacter);
            this.grpActions.Controls.Add(this.btnDeleteCharacter);
            this.grpActions.Location = new System.Drawing.Point(593, 36);
            this.grpActions.Name = "grpActions";
            this.grpActions.Size = new System.Drawing.Size(196, 195);
            this.grpActions.TabIndex = 8;
            this.grpActions.TabStop = false;
            this.grpActions.Text = "Дії";
            // 
            // grpSave
            // 
            this.grpSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSave.Controls.Add(this.btnSaveJson);
            this.grpSave.Controls.Add(this.btnSaveXml);
            this.grpSave.Controls.Add(this.btnLoadCharacters);
            this.grpSave.Location = new System.Drawing.Point(593, 237);
            this.grpSave.Name = "grpSave";
            this.grpSave.Size = new System.Drawing.Size(196, 147);
            this.grpSave.TabIndex = 9;
            this.grpSave.TabStop = false;
            this.grpSave.Text = "Збереження";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 400);
            this.Controls.Add(this.grpSave);
            this.Controls.Add(this.grpActions);
            this.Controls.Add(this.lblCharacters);
            this.Controls.Add(this.lstCharacters);
            this.MinimumSize = new System.Drawing.Size(820, 445);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RPG Character Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpActions.ResumeLayout(false);
            this.grpSave.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCharacters;
        private System.Windows.Forms.Button btnCreateCharacter;
        private System.Windows.Forms.Button btnCloneCharacter;
        private System.Windows.Forms.Button btnEditCharacter;
        private System.Windows.Forms.Button btnDeleteCharacter;
        private System.Windows.Forms.Button btnSaveJson;
        private System.Windows.Forms.Button btnSaveXml;
        private System.Windows.Forms.Button btnLoadCharacters;
        private System.Windows.Forms.Label lblCharacters;
        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.GroupBox grpSave;
    }
}