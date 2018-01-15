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
        Login loginForm;

        public Scenario(Login login)
        {
            InitializeComponent();
            loginForm = login;
        }

        private void Scenario_Load(object sender, EventArgs e)
        {
            foreach (DataRow scenario in database.GetScenario().Rows)
            {
                comboBoxScenario.Items.Add(scenario["Scenarionaam"]);
            }           
        }

        private void ButtonSelecteerScenario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Groepmaker groepmakerForm = new Groepmaker(this);
            groepmakerForm.ShowDialog();
        }

        private void ComboBoxScenario_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBoxScenarioBeschrijving.Text = database.GetBeschrijving(comboBoxScenario.SelectedItem.ToString());
        }

        private void Scenario_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginForm.Show();
        }
    }
}
