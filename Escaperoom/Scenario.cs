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
    public partial class Scenario : Form
    {
        ConnectieDB database = new ConnectieDB();
        Login loginform;

        public Scenario(Login login)
        {
            InitializeComponent();
            loginform = login;
        }

        private void Scenario_Load(object sender, EventArgs e)
        {
            foreach (DataRow scenario in database.GetScenario().Rows)
            {
                comboBoxScenarios.Items.Add(scenario["Scenarionaam"]);
            }           
        }

        private void ButtonSelecteerScenario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Groepmaker groepmaker = new Groepmaker(this);
            groepmaker.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = database.GetBeschrijving(comboBoxScenarios.SelectedItem.ToString());
        }

        private void Scenario_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginform.Show();
        }
    }
}
