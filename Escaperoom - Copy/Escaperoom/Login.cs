﻿using Escaperoom.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escaperoom
{
    public partial class Login : Form
    {
        ConnectieDB login = new ConnectieDB();

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (login.inlogcheck(textBox1.Text, textBox2.Text) == 0)
            {
                MessageBox.Show("Fout");
            }
            else
            {
                /*
                Login.Username = textBox1.Text;
                Login.Password = textBox2.Text;
                */
                this.Hide();
                Scenario form2 = new Scenario();
                form2.ShowDialog();

            }
        }
        // voor eventueel als we form 2 willen koppelen met form 1.
        /*
        private static string username;

        public static string Username
        {
            get { return username; }
            set { username = value; }
        }


        private static string password;

        public static string Password
        {
            get { return username; }
            set { username = value; }
        }
        */
    }
}
