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
    public partial class AdminBookingForm : Form
    {
        public AdminBookingForm()
        {
            InitializeComponent();
        }

        private void AdminBookingForm_Load(object sender, EventArgs e)
        {
            List<string> booking_list = SQLClass.Select(
                "SELECT booking.User, booking.comedate, booking.outdate, booking.room_id, hotels.Name, rooms.Name " + 
                " FROM booking" + 
                   " JOIN rooms ON rooms.ID = booking.room_id"+
                   " JOIN hotels ON hotels.ID = rooms.Hotel_ID");

            panel1.Controls.Clear();
            int y = 20;
            for (int i = 0; i < booking_list.Count; i += 6)
            {
                Label lbl0 = new Label();
                lbl0.Location = new Point(16, y);
                lbl0.Size = new Size(150, 30);
                lbl0.Font = new Font("Microsoft Sans Serif", 12);
                lbl0.Text = booking_list[i];
                lbl0.Tag = booking_list[i+3];
                lbl0.AccessibleName = booking_list[i + 1];
                lbl0.AccessibleDescription = booking_list[i + 2];
                panel1.Controls.Add(lbl0);

                Label lbl1 = new Label();
                lbl1.Location = new Point(216, y);
                lbl1.Size = new Size(150, 30);
                lbl1.Font = new Font("Microsoft Sans Serif", 12);
                lbl1.Text = booking_list[ i + 1];
                panel1.Controls.Add(lbl1);

                Label lbl2 = new Label();
                lbl2.Location = new Point(416, y);
                lbl2.Size = new Size(150, 30);
                lbl2.Font = new Font("Microsoft Sans Serif", 12);
                lbl2.Text = booking_list[i + 2];
                panel1.Controls.Add(lbl2);

                Label lbl3 = new Label();
                lbl3.Location = new Point(616, y);
                lbl3.Size = new Size(180, 30);
                lbl3.Font = new Font("Microsoft Sans Serif", 12);
                lbl3.Text = booking_list[i + 4];
                panel1.Controls.Add(lbl3);


                Label lbl4 = new Label();
                lbl4.Location = new Point(800, y);
                lbl4.Size = new Size(250, 30);
                lbl4.Font = new Font("Microsoft Sans Serif", 12);
                lbl4.Text =booking_list[i + 5];
                panel1.Controls.Add(lbl4);

               
                

                

                Button btn = new Button();
                btn.Location = new Point(1200, y);
                btn.Size = new Size(100, 30);
                btn.Font = new Font("Microsoft Sans Serif", 12);
                btn.Click += new EventHandler(DeleteBookingClick);
                btn.Text = "Удалить";
                panel1.Controls.Add(btn);

                y += 35;
            }
        }

        private void DeleteBookingClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int y = btn.Location.Y;

            foreach (Control control in panel1.Controls)
            {
                if (control.Location == new Point(16, y))
                {
                    SQLClass.Update("DELETE FROM booking" + " WHERE user = '" + control.Text + "'" +
                                                              " AND room_id = '" + control.Tag + "'" +
                                                              " AND comedate = '" + Convert.ToDateTime(control.AccessibleName).ToString("yyyy-MM-dd") + "'" +
                                                              " AND outdate = '" + Convert.ToDateTime(control.AccessibleDescription).ToString("yyyy-MM-dd") + "'");
                                                               
                    AdminBookingForm_Load(sender, e);
                    return;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
