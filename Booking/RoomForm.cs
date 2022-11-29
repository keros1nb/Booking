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
        public static int Rating;
        string id = "";
        int qty = 0;

        public RoomForm(string hotel_id, string Room_id)
        {
            InitializeComponent();

            id = Room_id;

            List<string> otel = MainForm.MySelect("SELECT Name, City, Rating, Image, Address FROM hotels WHERE ID ='" + hotel_id + "'");
            List<string> Room = MainForm.MySelect("SELECT Name, Price, Image, quantity ID FROM Rooms WHERE ID ='" + Room_id + "'");

            Text = otel[0] + ": " + Room[0];
            qty = Convert.ToInt32(Room[3]);
            label1.Text = otel[0];
            label3.Text = Room[0];
            label4.Text = otel[4];
            Rating = Convert.ToInt32(otel[2]);
            try
            {
                pictureBox1.Load("../../Pictures/" + Room[2]);
            }
            catch (Exception) { };

            int x = 330;
            for (int i = 0; i < Rating; i++)
            {
                PictureBox box = new PictureBox();
                box.Load("../../Pictures/Star.png");
                box.Location = new Point(x, 50);
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

            #region Mistakes checker
            if (MainForm.Login  == "")
            {
                MessageBox.Show("Вы не авторизованы");
                return;
            }
            DateTime dt = dateTimePicker1.Value;
            while (dt <= dateTimePicker2.Value.AddDays(0.5)) 
            {
                List<string> existBooking = MainForm.MySelect("SELECT COUNT(*) FROM booking " +
                        "WHERE comedate <= '" + dt.ToString("yyyy-MM-dd") + "'" +
                        "AND outdate >=  '" + dt.ToString("yyyy-MM-dd") + "'");
                if (Convert.ToInt32(existBooking[0]) >= qty)
                {
                    MessageBox.Show("На данные даты отсутсвуют места, выберите другие.");
                    return;
                }
                dt = dt.AddDays(1);
           }
            #endregion


            MainForm.MyUpdate("INSERT INTO booking(User, comedate, outdate, room_id) VALUES(" +
                                                                "'" + MainForm.Login + "'," +
                                                                "'" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'," +
                                                                "'" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "'," +
                                                                 id + ")");

            MessageBox.Show("Успешно!");
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
