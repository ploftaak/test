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
    public partial class Groepen_koppelen : Form
    {
        ConnectieDB database = new ConnectieDB();
        List<string> groep1 = new List<string>();

        public Groepen_koppelen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string name = deelnemerBox.Text;
            groep1.Add(name);
            foreach (string naam in groep1)
            {
                listBox1.Items.Add(naam);
            }            
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
            if (database.AddGroep(groepnaamBox.Text) == true)
            {
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Groepen_koppelen_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Groeplijst lijstGroepen = new Groeplijst();
            lijstGroepen.ShowDialog();
            //Groep groep = lijstGroepen.groep;            

            string selectedNaam = lijstGroepen.item;

            database.GetLeerlingenLijst(1);
            List<Leerling> LeerlingenLijst = database.GetLeerlingenLijst(1);
            listBox1.DataSource = new BindingSource(LeerlingenLijst, null);
            listBox1.DisplayMember = "Naam";

            groepnaamBox.Text = selectedNaam;
        }
    }
}
