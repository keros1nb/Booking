using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using System.Net;

namespace Booking
{
    public partial class AdminHF : Form
    {
        public AdminHF()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        string address = "";

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() ==DialogResult.OK)
            {
                address = openFileDialog1.FileName;
                pictureBox1.Load(address);
                System.IO.File.Copy(address, "../../Pictures/" + System.IO.Path.GetFileName(address));
                address = System.IO.Path.GetFileName(address);
            }    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm.MyUpdate("INSERT INTO hotels (Name, City, Rating, Image, Address)" +
            "VALUES('"+ textBox1.Text +"', '"+ textBox2.Text + "', '"+ textBox3.Text + "', '"+ address + "', '" + textBox4.Text + "')");
     
            MessageBox.Show("Сохранено");
            AdminHF_Load(sender, e);            
            return;
        }
        
        private void AdminHF_Load(object sender, EventArgs e)
        {
            List<string> list = MainForm.MySelect("SELECT Name, City, Rating, Image, Address FROM hotels");

            panel1.Controls.Clear();
            int y = 30;
            for (int i = 0; i < list.Count; i+=5)
            {
                Label lbl = new Label();
                lbl.Location = new Point(50, y);
                lbl.Size = new Size(200, 30);
                lbl.Font = new Font("Microsoft Sans Serif", 12);
                lbl.Text = list[i];
                panel1.Controls.Add(lbl);

                Button btn = new Button();
                btn.Location = new Point(350, y);
                btn.Size = new Size(100, 30);
                btn.Font = new Font("Microsoft Sans Serif", 12);
                btn.Click += new EventHandler(DelteHotel_Click);
                btn.Text = "Удалить";
                panel1.Controls.Add(btn);

                y += 35;
            }
        }

        private void DelteHotel_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender; 
            int y = btn.Location.Y;
          
            foreach(Control control in panel1.Controls)
            {
                if(control.Location == new Point(50, y))
                {
                  MainForm.MyUpdate("DELETE FROM hotels WHERE Name = '"+ control.Text +"'");
                    AdminHF_Load(sender, e);
                    return;
                }
            }
        }
    }
}
