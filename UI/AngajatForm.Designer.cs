namespace Tema1.UI
{
    partial class AngajatForm
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
            this.button_adaugaAnunt = new System.Windows.Forms.Button();
            this.button_stergeAnunt = new System.Windows.Forms.Button();
            this.button_editAnunt = new System.Windows.Forms.Button();
            this.comboBox_titlu_anunt = new System.Windows.Forms.ComboBox();
            this.button_afiseazaAnunt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_titluAnunt = new System.Windows.Forms.TextBox();
            this.textBox_descriereAnunt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox_selecteazaAnunt = new System.Windows.Forms.GroupBox();
            this.groupBox_selecteazaAnunt.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Logat ca angajat";
            // 
            // button_adaugaAnunt
            // 
            this.button_adaugaAnunt.Location = new System.Drawing.Point(482, 50);
            this.button_adaugaAnunt.Name = "button_adaugaAnunt";
            this.button_adaugaAnunt.Size = new System.Drawing.Size(99, 23);
            this.button_adaugaAnunt.TabIndex = 1;
            this.button_adaugaAnunt.Text = "Adauga Anunt";
            this.button_adaugaAnunt.UseVisualStyleBackColor = true;
            this.button_adaugaAnunt.Click += new System.EventHandler(this.button_adaugaAnunt_Click);
            // 
            // button_stergeAnunt
            // 
            this.button_stergeAnunt.Location = new System.Drawing.Point(482, 123);
            this.button_stergeAnunt.Name = "button_stergeAnunt";
            this.button_stergeAnunt.Size = new System.Drawing.Size(99, 23);
            this.button_stergeAnunt.TabIndex = 2;
            this.button_stergeAnunt.Text = "Sterge Anunt";
            this.button_stergeAnunt.UseVisualStyleBackColor = true;
            this.button_stergeAnunt.Click += new System.EventHandler(this.button_stergeAnunt_Click);
            // 
            // button_editAnunt
            // 
            this.button_editAnunt.Location = new System.Drawing.Point(482, 164);
            this.button_editAnunt.Name = "button_editAnunt";
            this.button_editAnunt.Size = new System.Drawing.Size(99, 23);
            this.button_editAnunt.TabIndex = 3;
            this.button_editAnunt.Text = "Editeaza Anunt";
            this.button_editAnunt.UseVisualStyleBackColor = true;
            this.button_editAnunt.Click += new System.EventHandler(this.button_editAnunt_Click);
            // 
            // comboBox_titlu_anunt
            // 
            this.comboBox_titlu_anunt.FormattingEnabled = true;
            this.comboBox_titlu_anunt.Location = new System.Drawing.Point(120, 13);
            this.comboBox_titlu_anunt.Name = "comboBox_titlu_anunt";
            this.comboBox_titlu_anunt.Size = new System.Drawing.Size(280, 21);
            this.comboBox_titlu_anunt.TabIndex = 8;
            this.comboBox_titlu_anunt.SelectedIndexChanged += new System.EventHandler(this.comboBox_titlu_anunt_SelectedIndexChanged);
            // 
            // button_afiseazaAnunt
            // 
            this.button_afiseazaAnunt.Location = new System.Drawing.Point(482, 86);
            this.button_afiseazaAnunt.Name = "button_afiseazaAnunt";
            this.button_afiseazaAnunt.Size = new System.Drawing.Size(99, 23);
            this.button_afiseazaAnunt.TabIndex = 9;
            this.button_afiseazaAnunt.Text = "Afiseaza Anunturi";
            this.button_afiseazaAnunt.UseVisualStyleBackColor = true;
            this.button_afiseazaAnunt.Click += new System.EventHandler(this.button_afiseazaAnunt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Titlu anunt:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descriere anunt:";
            // 
            // textBox_titluAnunt
            // 
            this.textBox_titluAnunt.Location = new System.Drawing.Point(144, 89);
            this.textBox_titluAnunt.Name = "textBox_titluAnunt";
            this.textBox_titluAnunt.Size = new System.Drawing.Size(280, 20);
            this.textBox_titluAnunt.TabIndex = 6;
            // 
            // textBox_descriereAnunt
            // 
            this.textBox_descriereAnunt.Location = new System.Drawing.Point(144, 130);
            this.textBox_descriereAnunt.Name = "textBox_descriereAnunt";
            this.textBox_descriereAnunt.Size = new System.Drawing.Size(280, 20);
            this.textBox_descriereAnunt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Selecteaza anunt: ";
            // 
            // groupBox_selecteazaAnunt
            // 
            this.groupBox_selecteazaAnunt.Controls.Add(this.label4);
            this.groupBox_selecteazaAnunt.Controls.Add(this.comboBox_titlu_anunt);
            this.groupBox_selecteazaAnunt.Location = new System.Drawing.Point(24, 183);
            this.groupBox_selecteazaAnunt.Name = "groupBox_selecteazaAnunt";
            this.groupBox_selecteazaAnunt.Size = new System.Drawing.Size(417, 40);
            this.groupBox_selecteazaAnunt.TabIndex = 11;
            this.groupBox_selecteazaAnunt.TabStop = false;
            this.groupBox_selecteazaAnunt.Visible = false;
            // 
            // AngajatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 319);
            this.Controls.Add(this.groupBox_selecteazaAnunt);
            this.Controls.Add(this.button_afiseazaAnunt);
            this.Controls.Add(this.textBox_descriereAnunt);
            this.Controls.Add(this.textBox_titluAnunt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_editAnunt);
            this.Controls.Add(this.button_stergeAnunt);
            this.Controls.Add(this.button_adaugaAnunt);
            this.Controls.Add(this.label1);
            this.Name = "AngajatForm";
            this.Text = "Angajat";
            this.Load += new System.EventHandler(this.AngajatForm_Load);
            this.groupBox_selecteazaAnunt.ResumeLayout(false);
            this.groupBox_selecteazaAnunt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_adaugaAnunt;
        private System.Windows.Forms.Button button_stergeAnunt;
        private System.Windows.Forms.Button button_editAnunt;
        private System.Windows.Forms.ComboBox comboBox_titlu_anunt;
        private System.Windows.Forms.Button button_afiseazaAnunt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_titluAnunt;
        private System.Windows.Forms.TextBox textBox_descriereAnunt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox_selecteazaAnunt;
    }
}