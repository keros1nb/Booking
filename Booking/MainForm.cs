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

namespace Booking
{
    public partial class MainForm : Form
    {
        const string CONNECTION_STRING =
            "SslMode=none;Server=localhost;Database=booking;port=3306;Uid=root;";

        public static List<Hotel> hotels = new List<Hotel>();
      
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
                

        public MainForm()
        {
            InitializeComponent();

            List<string> otels = MySelect("SELECT Name, City, Rating, Image FROM hotels");
            
            for(int i=0; i<otels.Count; i+=4)
            { 

                Hotel hotel = new Hotel(otels[i], otels[i+1], Convert.ToInt32(otels[i+2]), otels[i+3]);
                hotels.Add(hotel);
               

            }
           
           
           int x = 40;
            foreach(Hotel hotel in hotels)
            {
                hotel.pb.Location = new Point(x, 30);
                hotel.pb.Size = new Size(200, 180);
                hotel.pb.Image = hotel.pb.Image;
                hotel.pb.SizeMode = PictureBoxSizeMode.Zoom;
                hotel.pb.Click += new EventHandler(pictureBox1_Click);
                HotelsPanel.Controls.Add(hotel.pb);

                hotel.lbl.Location = new Point(x, 210);
                hotel.lbl.Size = new Size(200, 30);
                hotel.lbl.Font = new Font("Microsoft Sans Serif", 12);
                hotel.lbl.Text = hotel.Name;
                hotel.lbl.Click += new EventHandler(label4_Click);
                HotelsPanel.Controls.Add(hotel.lbl);



                x += 220;
            }
        }


        private void FilrtButton_Click(object sender, EventArgs e)
        {
            if(FiltrPanel.Size.Height < 50)
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
            foreach(Hotel hotel in hotels)
            {
                if(hotel.pb.Image == pb.Image)
                {
                    HotelForm hf = new HotelForm(hotel.Name);
                    hf.ShowDialog();
                }
            }
            ;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            foreach (Hotel hotel in hotels)
            {
                if (hotel.Name == lb.Text)
                {
                    HotelForm hf = new HotelForm(hotel.Name);
                    hf.ShowDialog();
                }
            }
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
    }
}
