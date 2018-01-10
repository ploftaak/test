using Escaperoom.Classes;
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
        ConnectieDB Db = new ConnectieDB();

 

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (Db.inlogcheck(textBoxUsername.Text, textBoxPassword.Text) == 0)
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

                textBoxUsername.Clear();
                textBoxPassword.Clear();

                ActiveControl = textBoxUsername;

                Scenario scenarioForm = new Scenario(this);
                scenarioForm.ShowDialog();

            }
        }
    }
}
