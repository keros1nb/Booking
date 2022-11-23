using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.Common;
using MySql.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;

namespace Booking
{
    public partial class MainForm : Form
    {
        const string CONNECTION_STRING =
            "SslMode=none;Server=localhost;Database=booking;port=3306;Uid=root;";

        public static string Login = "";
        public static string NameSurname = "";
        public static int isAdmin = 0;



        public static List<string> MySelect(string cmdText)
        {

            List<string> list = new List<string>();
            MySqlCommand cmd = new MySqlCommand(cmdText, Program.CONN);
            DbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    list.Add(reader.GetValue(i).ToString());
                }

            }
            reader.Close();
            return list;
        }


        //summary
        //функция Update запроса /Insert/Delete
        // </summary>
        public static void MyUpdate(string cmdText)
        {
            MySqlCommand cmd = new MySqlCommand(cmdText, Program.CONN);
            DbDataReader reader = cmd.ExecuteReader();
            reader.Close();
        }



        public MainForm()
        {
            InitializeComponent();
           
            Found_Button_Click(null, null);
            List<string> cities = MySelect("SELECT Name FROM cities ORDER BY Name");
            CityComboBox.Items.Clear();
            CityComboBox.Items.Add("");
            foreach (string city in cities)
                CityComboBox.Items.Add(city);

        }


        private void FilrtButton_Click(object sender, EventArgs e)
        {
            if (FiltrPanel.Size.Height < 50)
            {
                FiltrPanel.Size = new Size(FiltrPanel.Size.Width, 145);
            }
            else
            {
                FiltrPanel.Size = new Size(FiltrPanel.Size.Width, FilrtButton.Size.Height);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            HotelForm hf = new HotelForm(pb.Tag.ToString());
            hf.ShowDialog();


        }

        private void label4_Click(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            HotelForm hf = new HotelForm(lb.Tag.ToString());
            hf.ShowDialog();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           

            
        }

        private void HotelsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminForm AF = new AdminForm();
            AF.Show();
        }

       

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Found_Click(object sender, EventArgs e)
        {
            
        }

        private void Found_Button_Click(object sender, EventArgs e)
        {
            HotelsPanel.Controls.Clear();
            string command = "SELECT Name, City, Rating, Image, ID FROM hotels WHERE 1";
            if (CityComboBox.Text != "")
                command += " AND City = '" + CityComboBox.Text + "'";
            if (RatingComboBox.Text != "")
                command += " AND Rating >= '" + RatingComboBox.Text + "'";
            List<string> otels = MySelect(command);

            int x = 40;
            for (int i = 0; i < otels.Count; i += 5)
            {



                PictureBox pb = new PictureBox();
                pb = new PictureBox();
                try
                {
                    pb.Load("../../Pictures/" + otels[i + 3]);
                }
                catch (Exception) { }
                pb.Location = new Point(x, 30);
                pb.Size = new Size(200, 180);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Tag = otels[i + 4];
                pb.Click += new EventHandler(pictureBox1_Click);
                HotelsPanel.Controls.Add(pb);


                Label lbl = new Label();
                lbl.Location = new Point(x, 210);
                lbl.Size = new Size(200, 30);
                lbl.Font = new Font("Microsoft Sans Serif", 12);
                lbl.Text = otels[i];
                lbl.Tag = otels[i + 4];
                lbl.Click += new EventHandler(label4_Click);
                HotelsPanel.Controls.Add(lbl);



                x += 220;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (button1.Text == "Выйти")
            {
                AuthPanel.Controls.Clear();
                button1.Text = "Войти";
                AuthPanel.Controls.Add(button1);
            }
            else 
            {
                AuthorizeForm AF = new AuthorizeForm();
                AF.ShowDialog();

                AuthPanel.Controls.Clear();
                button1.Text = "Выйти";
                AuthPanel.Controls.Add(button1);
                if (NameSurname != "")
                {
                    label5.Visible = true;
                    AccountButton.Visible = true;
                }
                if (isAdmin == 1)
                {
                    AdminButton.Visible = true;
                }
                label5.Text = NameSurname;
                AuthPanel.Controls.Add(label5);
                AuthPanel.Controls.Add(AccountButton);
                AuthPanel.Controls.Add(AdminButton);
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AccountForm AcF = new AccountForm();
            AcF.ShowDialog();
        }
    }
}
