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
        public Scenario()
        {
            InitializeComponent();
        }

        private void Scenario_Load(object sender, EventArgs e)
        {
            foreach (DataRow scenario in database.GetScenario().Rows)
            {
                comboBox1.Items.Add(scenario["Scenarionaam"]);
            }           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Groepen_koppelen form3 = new Groepen_koppelen();
            form3.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = database.GetBeschrijving(comboBox1.SelectedItem.ToString());
        }
    }
}
