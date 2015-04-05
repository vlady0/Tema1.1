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

namespace Tema1
{
    public partial class LoginForm : Form
    {
        UserService userServ;
        Angajat ang;
        String username;

        public LoginForm()
        {
            InitializeComponent();
        }                

        public void button_login_Click(object sender, EventArgs e)
        {
            username = textBox_username.Text;
            String password = textBox_password.Text;

            userServ = new UserService(username, password);
            ang = userServ.login(username, password);

            if (ang == null)
            {
                MessageBox.Show("Utilizator invalid! Mai incercati o data!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else                
            {
                if ( ang.role == "admin")
                {
                    AdminForm fa = new AdminForm();
                    fa.Show();
                    fa.setUsername(username);
                    MessageBox.Show("Bine ai venit admin " + username, "Info", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    AngajatForm fa = new AngajatForm();
                    fa.Show();
                    fa.setUsername(username);
                    MessageBox.Show("Bine ai venit user " + username, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
           
            //MessageBox.Show(ang.username);

        }

       
    }
}
