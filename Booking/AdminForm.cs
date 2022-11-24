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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminHF HF = new AdminHF();
            HF.Show();
        }
          
        private void button2_Click(object sender, EventArgs e)
        {
            AdminRF RF = new AdminRF();
            RF.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminUsersForm UF = new AdminUsersForm();
            UF.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminBookingForm ABF = new AdminBookingForm();
            ABF.Show();
        }
    }
}
