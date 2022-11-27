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

        private void questiondirect_CheckedChanged(object sender, EventArgs e)
        {            

                ajouter3.Visible = true;
                ajouter2.Visible = true;
                ajouter1.Visible = true;



        }

        private void qcm_CheckedChanged(object sender, EventArgs e)
        {
            ajouter1qcm.Visible = true;
            ajouter2qcm.Visible = true;
            ajouter3qcm.Visible = true;
        }

        private void ajouter1_Click(object sender, EventArgs e)
        {
            textbox1.Visible = true;
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
            checkBox2.Visible = true;
            checkBox3.Visible = true;
            checkBox4.Visible = true;
            textBox4.Visible = true;
        }

        private void ajouter2qcm_Click(object sender, EventArgs e)
        {
            checkBox6.Visible = true;
            checkBox7.Visible = true;
            checkBox8.Visible = true;
            textBox5.Visible = true;
        }

        private void ajouter3qcm_Click(object sender, EventArgs e)
        {
            checkBox9.Visible = true;
            checkBox10.Visible = true;
            checkBox11.Visible = true;
            textBox6.Visible = true;
        }

        private void creerexamen_Click(object sender, EventArgs e)
        {
            questiondirect.Visible = true;
            qcm.Visible = true;
        }

        private void textbox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connString = "Server=localhost;Database=table;Uid=root;Pwd=;";
                MySqlConnection mcon = new MySqlConnection(connString);
                mcon.Open();

                string cmdText = "INSERT INTO question_directe(textbox1) VALUES (@textbox1)";
                MySqlCommand cmd = new MySqlCommand(cmdText, mcon);
                cmd.Parameters.Add("@textbox1", textbox1.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Question Inserted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string connString = "Server=localhost;Database=table;Uid=root;Pwd=;";
                MySqlConnection mcon = new MySqlConnection(connString);
                mcon.Open();

                string cmdText = "INSERT INTO question_directe(textbox2) VALUES (@textbox2)";
                MySqlCommand cmd = new MySqlCommand(cmdText, mcon);
                cmd.Parameters.Add("@textbox2", textbox2.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Question Inserted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string connString = "Server=localhost;Database=table;Uid=root;Pwd=;";
                MySqlConnection mcon = new MySqlConnection(connString);
                mcon.Open();

                string cmdText = "INSERT INTO question_directe(textbox3) VALUES (@textbox3)";
                MySqlCommand cmd = new MySqlCommand(cmdText, mcon);
                cmd.Parameters.Add("@textbox3", textbox3.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Question Inserted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
