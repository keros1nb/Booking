namespace Booking
{
    partial class AdminUsersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FliterPanel = new System.Windows.Forms.Panel();
            this.UsersPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CityComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.UsersAgeTextBox = new System.Windows.Forms.TextBox();
            this.UsersFoundButton = new System.Windows.Forms.Button();
            this.FliterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FliterPanel
            // 
            this.FliterPanel.Controls.Add(this.UsersFoundButton);
            this.FliterPanel.Controls.Add(this.UsersAgeTextBox);
            this.FliterPanel.Controls.Add(this.label6);
            this.FliterPanel.Controls.Add(this.label2);
            this.FliterPanel.Controls.Add(this.label1);
            this.FliterPanel.Controls.Add(this.CityComboBox);
            this.FliterPanel.Location = new System.Drawing.Point(12, 12);
            this.FliterPanel.Name = "FliterPanel";
            this.FliterPanel.Size = new System.Drawing.Size(1138, 267);
            this.FliterPanel.TabIndex = 0;
            // 
            // UsersPanel
            // 
            this.UsersPanel.Location = new System.Drawing.Point(12, 285);
            this.UsersPanel.Name = "UsersPanel";
            this.UsersPanel.Size = new System.Drawing.Size(1138, 301);
            this.UsersPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(29, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выберите город";
            // 
            // CityComboBox
            // 
            this.CityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CityComboBox.FormattingEnabled = true;
            this.CityComboBox.Location = new System.Drawing.Point(33, 102);
            this.CityComboBox.Name = "CityComboBox";
            this.CityComboBox.Size = new System.Drawing.Size(275, 24);
            this.CityComboBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(403, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Выберите возраст";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(459, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Фильтр пользователей";
            // 
            // UsersAgeTextBox
            // 
            this.UsersAgeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsersAgeTextBox.Location = new System.Drawing.Point(408, 98);
            this.UsersAgeTextBox.Name = "UsersAgeTextBox";
            this.UsersAgeTextBox.Size = new System.Drawing.Size(243, 28);
            this.UsersAgeTextBox.TabIndex = 16;
            // 
            // UsersFoundButton
            // 
            this.UsersFoundButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsersFoundButton.Location = new System.Drawing.Point(720, 90);
            this.UsersFoundButton.Name = "UsersFoundButton";
            this.UsersFoundButton.Size = new System.Drawing.Size(264, 44);
            this.UsersFoundButton.TabIndex = 26;
            this.UsersFoundButton.Text = "Поиск";
            this.UsersFoundButton.UseVisualStyleBackColor = true;
            this.UsersFoundButton.Click += new System.EventHandler(this.UsersFoundButton_Click);
            // 
            // AdminUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 598);
            this.Controls.Add(this.UsersPanel);
            this.Controls.Add(this.FliterPanel);
            this.Name = "AdminUsersForm";
            this.Text = "AdminUsersForm";
            this.Load += new System.EventHandler(this.AdminUsersForm_Load);
            this.FliterPanel.ResumeLayout(false);
            this.FliterPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FliterPanel;
        private System.Windows.Forms.Panel UsersPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CityComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox UsersAgeTextBox;
        private System.Windows.Forms.Button UsersFoundButton;
    }
}