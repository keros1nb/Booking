﻿using System;
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
    public partial class AuthorizeForm : Form
    {
        public AuthorizeForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistrationForm RF = new RegistrationForm();
            RF.Show();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            List<string> user_data = SQLClass.Select(
            "SELECT Login, Name, Surname, Admin_ID FROM users WHERE Login = '" + LoginTextBox.Text + "' and Password = '" + PasswordTextBox.Text + "'");

           
            if (user_data.Count > 0)
            {
                MainForm.isAdmin = (user_data[3] == "1");
                MainForm.Login = user_data[0];
                MainForm.NameSurname = user_data[1] + " " + user_data[2];
               
                Close();
            }
            else
            {
                MessageBox.Show("Логин или пароль был указан неправильно или аккаунт не найден, хотите зарегистрироваться?");
            }

            
        }

        private void AuthorizeForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
