using Escaperoom.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escaperoom
{
    public partial class Groepmaker : Form
    {
        ConnectieDB database = new ConnectieDB();
        List<string> groep1 = new List<string>();
        int groep_id;

        Scenario scenarioForm;

        public Groepmaker(Scenario scenario)
        {
            InitializeComponent();
            scenarioForm = scenario;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // leerling toevoegen
            string name = deelnemerBox.Text;
            database.AddLeerling(name);
            
            // leerling toevoegen aan groep
            // database.AddLeerlingToGroep(leerling_id, this.groep_id);
            // listbox verniewen
            // get_leerlingen();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Er is geen deelnemer geselecteerd om te verwijderen.");
            }
            else
            {
                groep1.Remove(listBox1.SelectedItem.ToString());
                listBox1.Items.Remove(listBox1.SelectedItem); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int groepId = database.AddGroep(groepnaamBox.Text);
            if (groepId != -1)
            {
                this.groep_id = groepId;
                if (groep1.Count > 1)
                {
                    foreach (string naam in groep1)
                    {
                        database.AddLeerling(naam);
                    }

                    groepnaamBox.Clear();
                    deelnemerBox.Clear();
                    listBox1.Items.Clear();
                    MessageBox.Show("Groep aangemaakt!");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Er zijn geen deelnemers.");
                }

            }
            else
            {
                MessageBox.Show("Voer een groepsnaam in.");
            }
       
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Groeplijst lijstGroepen = new Groeplijst();
            lijstGroepen.ShowDialog();
            //Groep groep = lijstGroepen.groep;            

            this.groep_id = lijstGroepen.id;
            string selectedNaam = lijstGroepen.item;
            groepnaamBox.Text = selectedNaam;

            get_leerlingen();
        }

        private void get_leerlingen()
        {
            if(groep_id.ToString() == "" )
            {
                MessageBox.Show("Geen groep geselecteerd");
                
            }
            else
            {
                List<Leerling> LeerlingenLijst = database.GetLeerlingenLijst(this.groep_id);
                listBox1.DataSource = new BindingSource(LeerlingenLijst, null);
                listBox1.DisplayMember = "Naam";
            }
        }

        private void Groepmaker_FormClosed(object sender, FormClosedEventArgs e)
        {
            scenarioForm.Show();
        }
    }
}
