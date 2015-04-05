namespace Tema1.UI
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button_creareContAngajat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_newUsername = new System.Windows.Forms.TextBox();
            this.textBox_newPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Creare = new System.Windows.Forms.Button();
            this.groupBox_creareCont = new System.Windows.Forms.GroupBox();
            this.comboBox_role = new System.Windows.Forms.ComboBox();
            this.button_viz_raport = new System.Windows.Forms.Button();
            this.button_admin_to_user = new System.Windows.Forms.Button();
            this.label_numeAdmin = new System.Windows.Forms.Label();
            this.groupBox_creareCont.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Logat ca admin: ";
            // 
            // button_creareContAngajat
            // 
            this.button_creareContAngajat.Location = new System.Drawing.Point(26, 41);
            this.button_creareContAngajat.Name = "button_creareContAngajat";
            this.button_creareContAngajat.Size = new System.Drawing.Size(120, 24);
            this.button_creareContAngajat.TabIndex = 1;
            this.button_creareContAngajat.Text = "Creeaza cont angajat";
            this.button_creareContAngajat.UseVisualStyleBackColor = true;
            this.button_creareContAngajat.Click += new System.EventHandler(this.button_creareContAngajat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // textBox_newUsername
            // 
            this.textBox_newUsername.Location = new System.Drawing.Point(91, 12);
            this.textBox_newUsername.Name = "textBox_newUsername";
            this.textBox_newUsername.Size = new System.Drawing.Size(100, 20);
            this.textBox_newUsername.TabIndex = 4;
            // 
            // textBox_newPassword
            // 
            this.textBox_newPassword.Location = new System.Drawing.Point(91, 44);
            this.textBox_newPassword.Name = "textBox_newPassword";
            this.textBox_newPassword.Size = new System.Drawing.Size(100, 20);
            this.textBox_newPassword.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Role:";
            // 
            // button_Creare
            // 
            this.button_Creare.Location = new System.Drawing.Point(91, 118);
            this.button_Creare.Name = "button_Creare";
            this.button_Creare.Size = new System.Drawing.Size(100, 23);
            this.button_Creare.TabIndex = 8;
            this.button_Creare.Text = "Creeaza cont";
            this.button_Creare.UseVisualStyleBackColor = true;
            this.button_Creare.Click += new System.EventHandler(this.button_Creare_Click);
            // 
            // groupBox_creareCont
            // 
            this.groupBox_creareCont.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_creareCont.Controls.Add(this.comboBox_role);
            this.groupBox_creareCont.Controls.Add(this.button_Creare);
            this.groupBox_creareCont.Controls.Add(this.label4);
            this.groupBox_creareCont.Controls.Add(this.textBox_newPassword);
            this.groupBox_creareCont.Controls.Add(this.textBox_newUsername);
            this.groupBox_creareCont.Controls.Add(this.label3);
            this.groupBox_creareCont.Controls.Add(this.label2);
            this.groupBox_creareCont.Location = new System.Drawing.Point(26, 69);
            this.groupBox_creareCont.Name = "groupBox_creareCont";
            this.groupBox_creareCont.Size = new System.Drawing.Size(204, 154);
            this.groupBox_creareCont.TabIndex = 9;
            this.groupBox_creareCont.TabStop = false;
            this.groupBox_creareCont.Visible = false;
            // 
            // comboBox_role
            // 
            this.comboBox_role.DisplayMember = "admin";
            this.comboBox_role.FormattingEnabled = true;
            this.comboBox_role.Items.AddRange(new object[] {
            "admin",
            "user"});
            this.comboBox_role.Location = new System.Drawing.Point(91, 78);
            this.comboBox_role.Name = "comboBox_role";
            this.comboBox_role.Size = new System.Drawing.Size(100, 21);
            this.comboBox_role.TabIndex = 9;
            // 
            // button_viz_raport
            // 
            this.button_viz_raport.Location = new System.Drawing.Point(185, 42);
            this.button_viz_raport.Name = "button_viz_raport";
            this.button_viz_raport.Size = new System.Drawing.Size(141, 23);
            this.button_viz_raport.TabIndex = 10;
            this.button_viz_raport.Text = "Vizualizare raport Angajat";
            this.button_viz_raport.UseVisualStyleBackColor = true;
            this.button_viz_raport.Click += new System.EventHandler(this.button_viz_raport_Click);
            // 
            // button_admin_to_user
            // 
            this.button_admin_to_user.Location = new System.Drawing.Point(56, 252);
            this.button_admin_to_user.Name = "button_admin_to_user";
            this.button_admin_to_user.Size = new System.Drawing.Size(161, 23);
            this.button_admin_to_user.TabIndex = 11;
            this.button_admin_to_user.Text = "Modifica anunturi";
            this.button_admin_to_user.UseVisualStyleBackColor = true;
            this.button_admin_to_user.Click += new System.EventHandler(this.button_admin_to_user_Click);
            // 
            // label_numeAdmin
            // 
            this.label_numeAdmin.AutoSize = true;
            this.label_numeAdmin.Location = new System.Drawing.Point(104, 9);
            this.label_numeAdmin.Name = "label_numeAdmin";
            this.label_numeAdmin.Size = new System.Drawing.Size(0, 13);
            this.label_numeAdmin.TabIndex = 12;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 294);
            this.Controls.Add(this.label_numeAdmin);
            this.Controls.Add(this.button_admin_to_user);
            this.Controls.Add(this.button_viz_raport);
            this.Controls.Add(this.groupBox_creareCont);
            this.Controls.Add(this.button_creareContAngajat);
            this.Controls.Add(this.label1);
            this.Name = "AdminForm";
            this.Text = "Admin";
            this.groupBox_creareCont.ResumeLayout(false);
            this.groupBox_creareCont.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_creareContAngajat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_newUsername;
        private System.Windows.Forms.TextBox textBox_newPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Creare;
        private System.Windows.Forms.GroupBox groupBox_creareCont;
        private System.Windows.Forms.Button button_viz_raport;
        private System.Windows.Forms.Button button_admin_to_user;
        private System.Windows.Forms.ComboBox comboBox_role;
        private System.Windows.Forms.Label label_numeAdmin;
    }
}