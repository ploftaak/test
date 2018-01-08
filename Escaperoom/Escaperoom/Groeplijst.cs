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
    public partial class Groeplijst : Form
    {
        ConnectieDB database = new ConnectieDB();
        
        public List<Groep> lijstmetGroepen;
        public string item;
        public int id;
        public Groep groep;


        public Groeplijst()
        {
            InitializeComponent();
        }
        private void Groeplijst_Load(object sender, EventArgs e)
        {
            lijstmetGroepen = database.GetGroepenLijst();

            listBox1.DataSource = new BindingSource(lijstmetGroepen, null);
            listBox1.DisplayMember = "Naam";
            listBox1.ValueMember = "GroepID";
            
            /*foreach (string groep in lijstmetGroepen)
            {
                listBox1.Items.Add(groep);
            }*/
            
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            this.item = listBox1.GetItemText(listBox1.SelectedItem);
            int.TryParse(listBox1.GetItemText(listBox1.SelectedValue), out this.id);
            //this.groep = new Groep(listBox1.SelectedItem.ToString());            
            //Groep name = new Groep(listBox1.SelectedItem);


            // Hier functie komen voor het ophalen van de leerlingen.

            this.Hide();            
        }

    }
}
