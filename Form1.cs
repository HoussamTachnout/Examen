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
            textBox3.Visible = true;
        }

        private void ajouter2_Click(object sender, EventArgs e)
        {
            textBox2.Visible = true;
        }

        private void ajouter3_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string connString = "Server=localhost;Database=table;Uid=root;Pwd=;";
                MySqlConnection mcon = new MySqlConnection(connString);
                mcon.Open();

                string cmdText = "INSERT INTO question direct(textBox3) VALUES (@textBox3)";
                MySqlCommand cmd = new MySqlCommand(cmdText, mcon);
                cmd.Parameters.Add("@textBox3", textBox3.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Question Inserted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string connString = "Server=localhost;Database=table;Uid=root;Pwd=;";
                MySqlConnection mcon = new MySqlConnection(connString);
                mcon.Open();

                string cmdText = "INSERT INTO question direct(textBox2) VALUES (@textBox2)";
                MySqlCommand cmd = new MySqlCommand(cmdText, mcon);
                cmd.Parameters.Add("@textBox2", textBox2.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Question Inserted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string connString = "Server=localhost;Database=table;Uid=root;Pwd=;";
                MySqlConnection mcon = new MySqlConnection(connString);
                mcon.Open();

                string cmdText = "INSERT INTO question direct(textBox1) VALUES (@textBox1)";
                MySqlCommand cmd = new MySqlCommand(cmdText, mcon);
                cmd.Parameters.Add("@textBox1", textBox1.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Question Inserted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
