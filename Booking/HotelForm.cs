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



    public partial class HotelForm : Form
    {
        public static string Hotel_Name;
        public static int Rating;
        public static int hotelid;
       

        public HotelForm(string hotel_id)
        {
            InitializeComponent();

            List<string> otel = SQLClass.Select("SELECT Name, City, Rating, Image, Address FROM hotels WHERE ID ='" + hotel_id + "'");

            Text = otel[0];
            label1.Text = otel[0];
            Hotel_Name = otel[0];
            Rating = Convert.ToInt32(otel[2]);
            hotelid = Convert.ToInt32(hotel_id);
            try
            {
                pictureBox1.Load("../../Pictures/" + otel[3]);
            }
            catch (Exception) { };

            label5.Text = otel[4];

            if (MainForm.Login != "")
            {
                Opinion.Visible = true;
            }
            else
            {
                Opinion.Visible = false;
            }

            int x = 330;
            for (int i = 0; i < Rating; i++)
            {
                PictureBox box = new PictureBox();
                box.Load("../../Pictures/Star.png");
                box.Location = new Point(x, 10);
                box.Size = new Size(50, 50);
                box.SizeMode = PictureBoxSizeMode.Zoom;
                panel1.Controls.Add(box);

                x += 65;
            }

            List<string> Rooms = SQLClass.Select("SELECT Name, Price, Image, ID FROM Rooms WHERE Hotel_ID ='" + hotel_id + "'");

            x = 40;
            for (int i = 0; i < Rooms.Count; i += 4)
            {



                PictureBox pb = new PictureBox();
                pb = new PictureBox();
                try
                {
                    pb.Load("../../Pictures/" + Rooms[i + 2]);
                }
                catch (Exception) { }
                pb.Location = new Point(x, 10);
                pb.Size = new Size(200, 180);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                pb.Tag = Rooms[i + 3];
                pb.Click += new EventHandler(pictureBox6_Click);
                RoomsPanel.Controls.Add(pb);


                Label lbl = new Label();
                lbl.Location = new Point(x, 190);
                lbl.Size = new Size(500, 30);
                lbl.Font = new Font("Microsoft Sans Serif", 12);
                lbl.Text = Rooms[i];
                lbl.Tag = Rooms[i + 2];
                lbl.Click += new EventHandler(label3_Click);
                RoomsPanel.Controls.Add(lbl);



                x += 220;
            }
        }
            private void HotelForm_Load(object sender, EventArgs e)
            {

            }

            private void pictureBox6_Click(object sender, EventArgs e)
            {
                PictureBox pb = (PictureBox)sender;
                RoomForm rf = new RoomForm(hotelid.ToString(), pb.Tag.ToString());
                rf.Show();
            }
        
            private void label3_Click(object sender, EventArgs e)
            {
                Label lbl = (Label)sender;
            RoomForm rf = new RoomForm(hotelid.ToString(), lbl.Tag.ToString());
                rf.Show();
            }

            private void panel1_Paint(object sender, PaintEventArgs e)
            {

            }

            private void label2_Click(object sender, EventArgs e)
            {

            }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void OpinionButton_Click(object sender, EventArgs e)
        {
            SQLClass.Update("INSERT INTO rating (User, Hotel_ID, Rate, Comment)" +
                             "VALUES ('" + MainForm.Login + "', '" + hotelid + "', '" + numericUpDown1.Value.ToString() + "', '" +
                                     textBox1.Text + "')");
            MessageBox.Show("Спасибо");
            return;
        }

        private void HotelForm_Load_1(object sender, EventArgs e)
        {

        }
    }
    }

