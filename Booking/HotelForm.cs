using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking
{
    public struct Hotel
    {
        public string Name;
        public string City;
        public int Rating;
        public string Picture_Adress;
        public PictureBox pb;
        public Label lbl;

        public Hotel(string _Name, string _City, int _Rating, string _Address)
        {
            Name = _Name;
            City = _City;
            Rating = _Rating;
            Picture_Adress = _Address;
            pb = new PictureBox();
            try
            {
                pb.Load("../../Pictures/" + _Address);
            }
            catch (Exception) { }

       
            lbl = new Label();
        }
    }


    public partial class HotelForm : Form
    {
        public static string Hotel_Name;
        public static int Rating;

        public HotelForm(string hotel_name)
        {
            InitializeComponent();

            List<string> otel = MainForm.MySelect("SELECT Name, City, Rating, Image, Address FROM hotels WHERE Name ='" + hotel_name + "'");

            Text = otel[0];
            label1.Text = otel[0];
            Hotel_Name = otel[0];
            Rating = Convert.ToInt32(otel[2]);
            try
            {
                pictureBox1.Load("../../Pictures/" + otel[3]);
            }
            catch (Exception) { };

            label5.Text = otel[4];


            int x = 330;
            for (int i=0; i < Rating; i++)
            {
                PictureBox box = new PictureBox();
                box.Load("../../Pictures/Star.png");
                box.Location = new Point(x, 70);
                box.Size = new Size(50, 50);
                box.SizeMode = PictureBoxSizeMode.Zoom;
                panel1.Controls.Add(box);

                x += 65;
            }

           
        }

        private void HotelForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            RoomForm rf = new RoomForm(Hotel_Name, pb.Tag.ToString(), Rating);
            rf.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            RoomForm rf = new RoomForm(Hotel_Name, lbl.Text, Rating);
            rf.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
