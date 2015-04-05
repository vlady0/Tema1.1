using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tema1.BL;
using Tema1.Other;

namespace Tema1.UI
{
    public partial class AngajatForm : Form
    {
        AnunturiService anuntServ;
        Anunt anunt;
        String username;
        UserService userServ;
        Angajat ang;

        public AngajatForm()
        {            
            InitializeComponent();
            Fillcombo();
        }

        void Fillcombo()
        {
            anuntServ = new AnunturiService();
            string[] s = new string[100];
            s = anuntServ.fillCombo();
            //Console.WriteLine("FORM:  " + s[0] + s[1] + "\n");
      
            for (int i = 0; i < s.Length; i++)
            {
                if ( s[i] != null)                  
                    comboBox_titlu_anunt.Items.Add(s[i]);
                
            }                   
        }

      

        private void button_stergeAnunt_Click(object sender, EventArgs e)
        {
            //String titlu = textBox_titluAnunt.Text;
            String titlu = comboBox_titlu_anunt.Text;
            anuntServ = new AnunturiService(titlu);
            anunt = anuntServ.stergeAnunt(titlu);
            MessageBox.Show("Anunt sters!", "Stergere anunt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox_titluAnunt.Clear();
            textBox_descriereAnunt.Clear();
            comboBox_titlu_anunt.Items.Clear();
            Fillcombo();
            groupBox_selecteazaAnunt.Visible = false;

        }

        private void button_adaugaAnunt_Click(object sender, EventArgs e)
        {
            String titlu = textBox_titluAnunt.Text;
            String descriere = textBox_descriereAnunt.Text;

            anuntServ = new AnunturiService(titlu, descriere);
            anunt = anuntServ.adaugaAnunt(titlu, descriere);

            MessageBox.Show("Anunt adaugat!", "Adaugare anunt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox_descriereAnunt.Clear();
            textBox_titluAnunt.Clear();

            
            

            

            //Console.WriteLine("FSFDS: " + username);

        }

        private void button_editAnunt_Click(object sender, EventArgs e)
        {
            String titlu = comboBox_titlu_anunt.Text;
            String descriere = textBox_descriereAnunt.Text;
            
            anuntServ = new AnunturiService(titlu, descriere);
            anunt = anuntServ.editeazaAnunt(titlu, descriere);
            MessageBox.Show("Anunt modificat!", "Update anunt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textBox_descriereAnunt.Clear();
            textBox_titluAnunt.Clear();
            comboBox_titlu_anunt.Items.Clear();
            Fillcombo();
            groupBox_selecteazaAnunt.Visible = false;
        }

        private void AngajatForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox_titlu_anunt_SelectedIndexChanged(object sender, EventArgs e)
        {
            String titlu = comboBox_titlu_anunt.Text;
            
            anuntServ = new AnunturiService(titlu);
            anunt = anuntServ.afiseazaAnunt(titlu);
            //Console.WriteLine("FORM: " + anunt.getTitlu() + " " +anunt.getDescriere());
           
            String descriere = anunt.getDescriere();            

            textBox_titluAnunt.Text = titlu;
            textBox_descriereAnunt.Text = descriere;

            //Console.WriteLine(anunt.getDescriere());
              
        }

        private void button_afiseazaAnunt_Click(object sender, EventArgs e)
        {
            textBox_titluAnunt.Clear();
            textBox_descriereAnunt.Clear();
            groupBox_selecteazaAnunt.Visible = true;
            comboBox_titlu_anunt.Items.Clear();            
            Fillcombo();

            //String titlu = comboBox_titlu_anunt.Text;
            //anuntServ = new AnunturiService(titlu);
            //anunt = anuntServ.afiseazaAnunt(titlu);
           // MessageBox.Show("Anunt sters!", "Stergere anunt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //textBox_titluAnunt.Clear();
            //textBox_descriereAnunt.Text = anunt.getTitlu();
        }

        public void setUsername(string username)
        {           
            this.username = username;
        }
    }
}
