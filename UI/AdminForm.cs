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
using Tema1.UI;

namespace Tema1.UI
{
    public partial class AdminForm : Form
    {
        UserService userServ;
        Angajat ang;
        String username;

        public AdminForm()
        {
            InitializeComponent();         
        }

       

        public void button_creareContAngajat_Click(object sender, EventArgs e)
        {
            groupBox_creareCont.Visible = true;
        }

        public void button_Creare_Click(object sender, EventArgs e)
        {
            String newUsername = textBox_newUsername.Text;
            String newPassword = textBox_newPassword.Text;
            String newRole = comboBox_role.Text;


            userServ = new UserService(newUsername, newPassword, newRole);            
            ang = userServ.creareCont(newUsername, newPassword, newRole);

            if ( newRole == "admin")
            {
                MessageBox.Show("Admin creat!", "Creare cont", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("User creat!","Creare cont",MessageBoxButtons.OK,MessageBoxIcon.Information);

            groupBox_creareCont.Visible = false;
        }

        private void button_viz_raport_Click(object sender, EventArgs e)
        {            
            //userServ = new UserService();
            //int nrAnunturi = userServ.getNrAnunturi(username);

            //MessageBox.Show(nrAnunturi.ToString());
            MessageBox.Show("Raport");
        }

   

        private void button_admin_to_user_Click(object sender, EventArgs e)
        {
            AngajatForm af = new AngajatForm();
            af.Show();
            af.setUsername(username);
        }

        public void setUsername(string username)
        {          
            this.username = username;            
        }
    }
}
