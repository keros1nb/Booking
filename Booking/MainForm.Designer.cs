
namespace Booking
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.FiltrPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.RatingComboBox = new System.Windows.Forms.ComboBox();
            this.Found_Button = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.CityComboBox = new System.Windows.Forms.ComboBox();
            this.FilrtButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.HotelsPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.AuthPanel = new System.Windows.Forms.Panel();
            this.AccountButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.FiltrPanel.SuspendLayout();
            this.AuthPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FiltrPanel
            // 
            this.FiltrPanel.AutoScroll = true;
            this.FiltrPanel.Controls.Add(this.label4);
            this.FiltrPanel.Controls.Add(this.RatingComboBox);
            this.FiltrPanel.Controls.Add(this.Found_Button);
            this.FiltrPanel.Controls.Add(this.dateTimePicker2);
            this.FiltrPanel.Controls.Add(this.label3);
            this.FiltrPanel.Controls.Add(this.label2);
            this.FiltrPanel.Controls.Add(this.label1);
            this.FiltrPanel.Controls.Add(this.dateTimePicker1);
            this.FiltrPanel.Controls.Add(this.CityComboBox);
            this.FiltrPanel.Controls.Add(this.FilrtButton);
            this.FiltrPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FiltrPanel.Location = new System.Drawing.Point(0, 61);
            this.FiltrPanel.Name = "FiltrPanel";
            this.FiltrPanel.Size = new System.Drawing.Size(1367, 146);
            this.FiltrPanel.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Выберите рейтинг";
            // 
            // RatingComboBox
            // 
            this.RatingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RatingComboBox.FormattingEnabled = true;
            this.RatingComboBox.Items.AddRange(new object[] {
            "3",
            "4",
            "5"});
            this.RatingComboBox.Location = new System.Drawing.Point(315, 87);
            this.RatingComboBox.Name = "RatingComboBox";
            this.RatingComboBox.Size = new System.Drawing.Size(275, 33);
            this.RatingComboBox.TabIndex = 9;
            // 
            // Found_Button
            // 
            this.Found_Button.Location = new System.Drawing.Point(1190, 84);
            this.Found_Button.Name = "Found_Button";
            this.Found_Button.Size = new System.Drawing.Size(102, 33);
            this.Found_Button.TabIndex = 7;
            this.Found_Button.Text = "Найти";
            this.Found_Button.UseVisualStyleBackColor = true;
            this.Found_Button.Click += new System.EventHandler(this.Found_Button_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(927, 85);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(240, 30);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(922, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Выберите дату выезда";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(651, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Выберите дату заезда";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберите город";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(656, 85);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(238, 30);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // CityComboBox
            // 
            this.CityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CityComboBox.FormattingEnabled = true;
            this.CityComboBox.Location = new System.Drawing.Point(17, 87);
            this.CityComboBox.Name = "CityComboBox";
            this.CityComboBox.Size = new System.Drawing.Size(275, 33);
            this.CityComboBox.TabIndex = 1;
            // 
            // FilrtButton
            // 
            this.FilrtButton.Location = new System.Drawing.Point(0, 0);
            this.FilrtButton.Name = "FilrtButton";
            this.FilrtButton.Size = new System.Drawing.Size(124, 36);
            this.FilrtButton.TabIndex = 0;
            this.FilrtButton.Text = "Фильтр";
            this.FilrtButton.UseVisualStyleBackColor = true;
            this.FilrtButton.Click += new System.EventHandler(this.FilrtButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1233, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 33);
            this.button2.TabIndex = 8;
            this.button2.Text = "Админка";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // HotelsPanel
            // 
            this.HotelsPanel.AutoScroll = true;
            this.HotelsPanel.Location = new System.Drawing.Point(0, 213);
            this.HotelsPanel.Name = "HotelsPanel";
            this.HotelsPanel.Size = new System.Drawing.Size(1367, 374);
            this.HotelsPanel.TabIndex = 1;
            this.HotelsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.HotelsPanel_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AuthPanel
            // 
            this.AuthPanel.Controls.Add(this.label5);
            this.AuthPanel.Controls.Add(this.AccountButton);
            this.AuthPanel.Controls.Add(this.button1);
            this.AuthPanel.Controls.Add(this.button2);
            this.AuthPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AuthPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthPanel.Location = new System.Drawing.Point(0, 0);
            this.AuthPanel.Name = "AuthPanel";
            this.AuthPanel.Size = new System.Drawing.Size(1367, 55);
            this.AuthPanel.TabIndex = 2;
            // 
            // AccountButton
            // 
            this.AccountButton.Location = new System.Drawing.Point(641, 9);
            this.AccountButton.Name = "AccountButton";
            this.AccountButton.Size = new System.Drawing.Size(172, 39);
            this.AccountButton.TabIndex = 12;
            this.AccountButton.Text = "Личный кабинет";
            this.AccountButton.UseVisualStyleBackColor = true;
            this.AccountButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1367, 587);
            this.Controls.Add(this.AuthPanel);
            this.Controls.Add(this.HotelsPanel);
            this.Controls.Add(this.FiltrPanel);
            this.Name = "MainForm";
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FiltrPanel.ResumeLayout(false);
            this.FiltrPanel.PerformLayout();
            this.AuthPanel.ResumeLayout(false);
            this.AuthPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FiltrPanel;
        private System.Windows.Forms.Button FilrtButton;
        private System.Windows.Forms.Button Found_Button;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox CityComboBox;
        private System.Windows.Forms.Panel HotelsPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox RatingComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel AuthPanel;
        private System.Windows.Forms.Button AccountButton;
        private System.Windows.Forms.Label label5;
    }
}

