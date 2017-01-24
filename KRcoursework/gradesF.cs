using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace KRcoursework
{
    public partial class gradesF : Form
    {
        public gradesF()
        {
            InitializeComponent();
        }

        //
        OleDbConnection con2 = new OleDbConnection("Provider=MSDAORA;Data Source=XE;Persist Security Info=True;User ID=coursework;Password=cw1;Unicode=True;");//connection beeywen oracle and c#
        //

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            teadcherF ft = new teadcherF();
            ft.ShowDialog(); // показываем
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form1 fl = new Form1();

            using (var command = new OleDbCommand("select subject from users where login = ?",con2))
            {
                command.Parameters.AddWithValue("@Variable",Data.Login);
                con2.Open();
                Data.resultS = (string)command.ExecuteScalar();
                MessageBox.Show("Вaш предмет: "+Data.resultS);
                con2.Close();
            }
           
            OleDbDataAdapter oda = new OleDbDataAdapter("SELECT N_zalik , StGroup, FirstName, LastName," + Data.resultS + " From ShowStudMarks Order by StGroup, FirstName, LastName", con2);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
                con2.Close();
                dataGridView1.ReadOnly = true; 
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(Data.Login);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con2.Open();
                OleDbCommand update = new OleDbCommand("update timesheet set " + Data.resultS + "=" + (int)numericUpDown1.Value + "where N_zalik='" + textBox1.Text + "'",con2);
                update.ExecuteNonQuery();
                con2.Close();
                using (var command = new OleDbCommand("select subject from users where login = ?", con2))
                {
                    command.Parameters.AddWithValue("@Variable", Data.Login);
                    con2.Open();
                    Data.resultS = (string)command.ExecuteScalar();
                    //MessageBox.Show("Вaш предмет: " + Data.resultS);
                    con2.Close();
                }

                OleDbDataAdapter oda = new OleDbDataAdapter("SELECT N_zalik , StGroup, FirstName, LastName," + Data.resultS + " From ShowStudMarks Order by StGroup, FirstName, LastName", con2);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView1.DataSource = dt;
                con2.Close();
                dataGridView1.ReadOnly = true;
            }
            catch
            {
                MessageBox.Show("Введiть корректнi данi!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void gradesF_Load(object sender, EventArgs e)
        {
            using (var command = new OleDbCommand("select subject from users where login = ?", con2))
            {
                command.Parameters.AddWithValue("@Variable", Data.Login);
                con2.Open();
                Data.resultS = (string)command.ExecuteScalar();
                MessageBox.Show("Вaш предмет: " + Data.resultS);
                con2.Close();
            }

            OleDbDataAdapter oda = new OleDbDataAdapter("SELECT N_zalik , StGroup, FirstName, LastName," + Data.resultS + " From ShowStudMarks ", con2);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            con2.Close();
            dataGridView1.ReadOnly = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
