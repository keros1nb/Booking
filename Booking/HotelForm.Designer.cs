
namespace Booking
{
    partial class HotelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HotelForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Opinion = new System.Windows.Forms.Panel();
            this.OpinionButton = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label3A = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RoomsPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.Opinion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Opinion);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 310);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // Opinion
            // 
            this.Opinion.Controls.Add(this.OpinionButton);
            this.Opinion.Controls.Add(this.numericUpDown1);
            this.Opinion.Controls.Add(this.label3);
            this.Opinion.Controls.Add(this.label3A);
            this.Opinion.Controls.Add(this.textBox1);
            this.Opinion.Location = new System.Drawing.Point(354, 136);
            this.Opinion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Opinion.Name = "Opinion";
            this.Opinion.Size = new System.Drawing.Size(554, 158);
            this.Opinion.TabIndex = 8;
            // 
            // OpinionButton
            // 
            this.OpinionButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpinionButton.Location = new System.Drawing.Point(417, 89);
            this.OpinionButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OpinionButton.Name = "OpinionButton";
            this.OpinionButton.Size = new System.Drawing.Size(102, 54);
            this.OpinionButton.TabIndex = 4;
            this.OpinionButton.Text = "Отправить";
            this.OpinionButton.UseVisualStyleBackColor = true;
            this.OpinionButton.Click += new System.EventHandler(this.OpinionButton_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.Location = new System.Drawing.Point(417, 32);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(102, 26);
            this.numericUpDown1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(414, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Оцените (1-10)";
            // 
            // label3A
            // 
            this.label3A.AutoSize = true;
            this.label3A.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3A.Location = new System.Drawing.Point(8, 8);
            this.label3A.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3A.Name = "label3A";
            this.label3A.Size = new System.Drawing.Size(114, 19);
            this.label3A.TabIndex = 1;
            this.label3A.Text = "Оставьте отзыв";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 31);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(345, 113);
            this.textBox1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(352, 104);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "label5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(350, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 60);
            this.label2.TabIndex = 6;
            this.label2.Text = "Адрес:\r\n\r\n\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Гостиница \"Космос\"";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 72);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // RoomsPanel
            // 
            this.RoomsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RoomsPanel.Location = new System.Drawing.Point(0, 310);
            this.RoomsPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RoomsPanel.Name = "RoomsPanel";
            this.RoomsPanel.Size = new System.Drawing.Size(928, 277);
            this.RoomsPanel.TabIndex = 1;
            this.RoomsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.RoomsPanel_Paint);
            // 
            // HotelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 587);
            this.Controls.Add(this.RoomsPanel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HotelForm";
            this.Text = "Hotel";
            this.Load += new System.EventHandler(this.HotelForm_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Opinion.ResumeLayout(false);
            this.Opinion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel RoomsPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel Opinion;
        private System.Windows.Forms.Button OpinionButton;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label3A;
        private System.Windows.Forms.TextBox textBox1;
    }
}