using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Exam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ajouter1_Click(object sender, EventArgs e)
        {
            textbox1.Visible = true;
            button1.Visible = true;
        }

        private void ajouter2_Click(object sender, EventArgs e)
        {
            textbox2.Visible = true;
        }

        private void ajouter3_Click(object sender, EventArgs e)
        {
            textbox3.Visible = true;
        }

        private void ajouter1qcm_Click(object sender, EventArgs e)
        {
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            textbox4.Visible = true;
            button4.Visible = true;
        }

        private void ajouter2qcm_Click(object sender, EventArgs e)
        {
            radioButton4.Visible = true;
            radioButton5.Visible = true;
            radioButton6.Visible = true;
            textbox5.Visible = true;
        }

        private void ajouter3qcm_Click(object sender, EventArgs e)
        {
            radioButton7.Visible = true;
            radioButton8.Visible = true;
            radioButton9.Visible = true;
            textbox6.Visible = true;
        }

        private void creerexamen_Click(object sender, EventArgs e)
        {
            qsdirecte.Visible = true;
            qc.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connString = "Server=localhost;Database=table;Uid=root;Pwd=;";
                MySqlConnection mcon = new MySqlConnection(connString);
                mcon.Open();

                string cmdText = "INSERT INTO question_directe(Question1,Question2,Question3) VALUES (@textbox1,@textbox2,@textbox3)";
                MySqlCommand cmd = new MySqlCommand(cmdText, mcon);
                cmd.Parameters.Add("@textbox1", textbox1.Text);
                cmd.Parameters.Add("@textbox2", textbox2.Text);
                cmd.Parameters.Add("@textbox3", textbox3.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Question Inserted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void qc_CheckedChanged(object sender, EventArgs e)
        {
            creerexamen.Visible = false;
            ajouter1qcm.Visible = true;
            ajouter2qcm.Visible = true;
            ajouter3qcm.Visible = true;
            ajouter1.Visible = false;
            ajouter2.Visible = false;
            ajouter3.Visible = false;
            button1.Visible = false;
            textbox1.Visible = false;
            textbox2.Visible = false;
            textbox3.Visible = false;
        }

        private void qsdirecte_CheckedChanged(object sender, EventArgs e)
        {
            creerexamen.Visible = false;
            ajouter3.Visible = true;
            ajouter2.Visible = true;
            ajouter1.Visible = true;
            ajouter1qcm.Visible = false;
            ajouter2qcm.Visible = false;
            ajouter3qcm.Visible = false;
            textbox1.Visible = false;
            textbox2.Visible = false;
            textbox3.Visible = false;
            textbox4.Visible = false;
            textbox5.Visible = false;
            textbox6.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            radioButton7.Visible = false;
            radioButton8.Visible = false;
            radioButton9.Visible = false;
            button4.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string connString = "Server=localhost;Database=table;Uid=root;Pwd=;";
                MySqlConnection mcon = new MySqlConnection(connString);
                mcon.Open();

                string cmdText = "INSERT INTO qcm(Qcm1,Qcm2,Qcm3) VALUES (@textbox4,@textbox5,@textbox6)";
                MySqlCommand cmd = new MySqlCommand(cmdText, mcon);
                cmd.Parameters.Add("@textbox4", textbox4.Text);
                cmd.Parameters.Add("@textbox5", textbox5.Text);
                cmd.Parameters.Add("@textbox6", textbox6.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("QCM Inserted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
