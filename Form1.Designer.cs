namespace Exam
{
    partial class Form1
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
            this.qcm = new System.Windows.Forms.CheckBox();
            this.questiondirect = new System.Windows.Forms.CheckBox();
            this.textbox3 = new System.Windows.Forms.TextBox();
            this.textbox2 = new System.Windows.Forms.TextBox();
            this.textbox1 = new System.Windows.Forms.TextBox();
            this.ajouter3 = new System.Windows.Forms.Button();
            this.ajouter2 = new System.Windows.Forms.Button();
            this.ajouter1 = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.envoyer = new System.Windows.Forms.Button();
            this.annuler = new System.Windows.Forms.Button();
            this.ajouter1qcm = new System.Windows.Forms.Button();
            this.ajouter2qcm = new System.Windows.Forms.Button();
            this.ajouter3qcm = new System.Windows.Forms.Button();
            this.creerexamen = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // qcm
            // 
            this.qcm.AutoSize = true;
            this.qcm.Location = new System.Drawing.Point(250, 54);
            this.qcm.Name = "qcm";
            this.qcm.Size = new System.Drawing.Size(50, 17);
            this.qcm.TabIndex = 2;
            this.qcm.Text = "QCM";
            this.qcm.UseVisualStyleBackColor = true;
            this.qcm.Visible = false;
            this.qcm.CheckedChanged += new System.EventHandler(this.qcm_CheckedChanged);
            // 
            // questiondirect
            // 
            this.questiondirect.AutoSize = true;
            this.questiondirect.Location = new System.Drawing.Point(414, 54);
            this.questiondirect.Name = "questiondirect";
            this.questiondirect.Size = new System.Drawing.Size(99, 17);
            this.questiondirect.TabIndex = 3;
            this.questiondirect.Text = "Question Direct";
            this.questiondirect.UseVisualStyleBackColor = true;
            this.questiondirect.Visible = false;
            this.questiondirect.CheckedChanged += new System.EventHandler(this.questiondirect_CheckedChanged);
            // 
            // textbox3
            // 
            this.textbox3.Location = new System.Drawing.Point(305, 222);
            this.textbox3.Multiline = true;
            this.textbox3.Name = "textbox3";
            this.textbox3.Size = new System.Drawing.Size(262, 42);
            this.textbox3.TabIndex = 4;
            this.textbox3.Visible = false;
            this.textbox3.TextChanged += new System.EventHandler(this.textbox3_TextChanged);
            // 
            // textbox2
            // 
            this.textbox2.Location = new System.Drawing.Point(305, 153);
            this.textbox2.Multiline = true;
            this.textbox2.Name = "textbox2";
            this.textbox2.Size = new System.Drawing.Size(262, 42);
            this.textbox2.TabIndex = 5;
            this.textbox2.Visible = false;
            this.textbox2.TextChanged += new System.EventHandler(this.textbox2_TextChanged);
            // 
            // textbox1
            // 
            this.textbox1.Location = new System.Drawing.Point(305, 90);
            this.textbox1.Multiline = true;
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(262, 42);
            this.textbox1.TabIndex = 6;
            this.textbox1.Visible = false;
            this.textbox1.TextChanged += new System.EventHandler(this.textbox1_TextChanged);
            // 
            // ajouter3
            // 
            this.ajouter3.Location = new System.Drawing.Point(39, 222);
            this.ajouter3.Name = "ajouter3";
            this.ajouter3.Size = new System.Drawing.Size(126, 42);
            this.ajouter3.TabIndex = 7;
            this.ajouter3.Text = "Ajouter 3éme Question";
            this.ajouter3.UseVisualStyleBackColor = true;
            this.ajouter3.Visible = false;
            this.ajouter3.Click += new System.EventHandler(this.ajouter3_Click);
            // 
            // ajouter2
            // 
            this.ajouter2.Location = new System.Drawing.Point(39, 156);
            this.ajouter2.Name = "ajouter2";
            this.ajouter2.Size = new System.Drawing.Size(126, 39);
            this.ajouter2.TabIndex = 8;
            this.ajouter2.Text = "Ajouter 2éme Question";
            this.ajouter2.UseVisualStyleBackColor = true;
            this.ajouter2.Visible = false;
            this.ajouter2.Click += new System.EventHandler(this.ajouter2_Click);
            // 
            // ajouter1
            // 
            this.ajouter1.Location = new System.Drawing.Point(39, 90);
            this.ajouter1.Name = "ajouter1";
            this.ajouter1.Size = new System.Drawing.Size(126, 39);
            this.ajouter1.TabIndex = 9;
            this.ajouter1.Text = "Ajouter 1er Question";
            this.ajouter1.UseVisualStyleBackColor = true;
            this.ajouter1.Visible = false;
            this.ajouter1.Click += new System.EventHandler(this.ajouter1_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(567, 286);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(80, 17);
            this.checkBox3.TabIndex = 10;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.Visible = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(468, 286);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(80, 17);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Visible = false;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(657, 286);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(80, 17);
            this.checkBox4.TabIndex = 12;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.Visible = false;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(468, 330);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(80, 17);
            this.checkBox6.TabIndex = 14;
            this.checkBox6.Text = "checkBox6";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.Visible = false;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(567, 331);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(80, 17);
            this.checkBox7.TabIndex = 15;
            this.checkBox7.Text = "checkBox7";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.Visible = false;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(657, 332);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(80, 17);
            this.checkBox8.TabIndex = 16;
            this.checkBox8.Text = "checkBox8";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.Visible = false;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(468, 374);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(80, 17);
            this.checkBox9.TabIndex = 17;
            this.checkBox9.Text = "checkBox9";
            this.checkBox9.UseVisualStyleBackColor = true;
            this.checkBox9.Visible = false;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(567, 374);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(86, 17);
            this.checkBox10.TabIndex = 18;
            this.checkBox10.Text = "checkBox10";
            this.checkBox10.UseVisualStyleBackColor = true;
            this.checkBox10.Visible = false;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(659, 374);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(86, 17);
            this.checkBox11.TabIndex = 19;
            this.checkBox11.Text = "checkBox11";
            this.checkBox11.UseVisualStyleBackColor = true;
            this.checkBox11.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(250, 275);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(199, 33);
            this.textBox4.TabIndex = 20;
            this.textBox4.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(250, 318);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(199, 33);
            this.textBox5.TabIndex = 21;
            this.textBox5.Visible = false;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(250, 365);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(199, 33);
            this.textBox6.TabIndex = 22;
            this.textBox6.Visible = false;
            // 
            // envoyer
            // 
            this.envoyer.Location = new System.Drawing.Point(556, 397);
            this.envoyer.Name = "envoyer";
            this.envoyer.Size = new System.Drawing.Size(81, 52);
            this.envoyer.TabIndex = 23;
            this.envoyer.Text = "Envoyer";
            this.envoyer.UseVisualStyleBackColor = true;
            // 
            // annuler
            // 
            this.annuler.Location = new System.Drawing.Point(660, 397);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(77, 52);
            this.annuler.TabIndex = 24;
            this.annuler.Text = "Annuler";
            this.annuler.UseVisualStyleBackColor = true;
            // 
            // ajouter1qcm
            // 
            this.ajouter1qcm.Location = new System.Drawing.Point(54, 267);
            this.ajouter1qcm.Name = "ajouter1qcm";
            this.ajouter1qcm.Size = new System.Drawing.Size(91, 39);
            this.ajouter1qcm.TabIndex = 25;
            this.ajouter1qcm.Text = "Ajouter 1er QCM";
            this.ajouter1qcm.UseVisualStyleBackColor = true;
            this.ajouter1qcm.Visible = false;
            this.ajouter1qcm.Click += new System.EventHandler(this.ajouter1qcm_Click);
            // 
            // ajouter2qcm
            // 
            this.ajouter2qcm.Location = new System.Drawing.Point(54, 312);
            this.ajouter2qcm.Name = "ajouter2qcm";
            this.ajouter2qcm.Size = new System.Drawing.Size(91, 42);
            this.ajouter2qcm.TabIndex = 26;
            this.ajouter2qcm.Text = "Ajouter 2éme QCM";
            this.ajouter2qcm.UseVisualStyleBackColor = true;
            this.ajouter2qcm.Visible = false;
            this.ajouter2qcm.Click += new System.EventHandler(this.ajouter2qcm_Click);
            // 
            // ajouter3qcm
            // 
            this.ajouter3qcm.Location = new System.Drawing.Point(54, 360);
            this.ajouter3qcm.Name = "ajouter3qcm";
            this.ajouter3qcm.Size = new System.Drawing.Size(91, 43);
            this.ajouter3qcm.TabIndex = 27;
            this.ajouter3qcm.Text = "Ajouter 3éme QCM";
            this.ajouter3qcm.UseVisualStyleBackColor = true;
            this.ajouter3qcm.Visible = false;
            this.ajouter3qcm.Click += new System.EventHandler(this.ajouter3qcm_Click);
            // 
            // creerexamen
            // 
            this.creerexamen.Location = new System.Drawing.Point(7, 10);
            this.creerexamen.Name = "creerexamen";
            this.creerexamen.Size = new System.Drawing.Size(158, 61);
            this.creerexamen.TabIndex = 28;
            this.creerexamen.Text = "Créer Examen";
            this.creerexamen.UseVisualStyleBackColor = true;
            this.creerexamen.Click += new System.EventHandler(this.creerexamen_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(630, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 37);
            this.button1.TabIndex = 29;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(630, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 39);
            this.button2.TabIndex = 30;
            this.button2.Text = "Ajouter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(630, 225);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 39);
            this.button3.TabIndex = 31;
            this.button3.Text = "Ajouter";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.creerexamen);
            this.Controls.Add(this.ajouter3qcm);
            this.Controls.Add(this.ajouter2qcm);
            this.Controls.Add(this.ajouter1qcm);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.envoyer);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.checkBox11);
            this.Controls.Add(this.checkBox10);
            this.Controls.Add(this.checkBox9);
            this.Controls.Add(this.checkBox8);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.ajouter1);
            this.Controls.Add(this.ajouter2);
            this.Controls.Add(this.ajouter3);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.textbox2);
            this.Controls.Add(this.textbox3);
            this.Controls.Add(this.questiondirect);
            this.Controls.Add(this.qcm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox qcm;
        private System.Windows.Forms.CheckBox questiondirect;
        private System.Windows.Forms.TextBox textbox3;
        private System.Windows.Forms.TextBox textbox2;
        private System.Windows.Forms.TextBox textbox1;
        private System.Windows.Forms.Button ajouter3;
        private System.Windows.Forms.Button ajouter2;
        private System.Windows.Forms.Button ajouter1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button envoyer;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Button ajouter1qcm;
        private System.Windows.Forms.Button ajouter2qcm;
        private System.Windows.Forms.Button ajouter3qcm;
        private System.Windows.Forms.Button creerexamen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

