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
    public partial class RoomForm : Form
    {
        public RoomForm(string HotelName, string RoomName, int Rating)
        {
            InitializeComponent();

            Text = HotelName + ": " + RoomName;
            label1.Text = HotelName;
            label3.Text = RoomName;

            if(RoomName == "Двухместный номер")
            {
                pictureBox1.Load("../../Picture/2Seats.jpg");
            }


            if (RoomName == "Одноместный номер")
            {
                pictureBox1.Load("../../Picture/1Seat.jpg");
            }

            int x = 330;
            for (int i = 0; i < Rating; i++)
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Успешно!");
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
