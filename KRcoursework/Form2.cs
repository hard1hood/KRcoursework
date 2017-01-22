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
using Oracle.DataAccess.Client;
namespace KRcoursework
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Form1 f1 = new Form1();
            //f1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            //registerF f5 = new registerF();
            //f5.ShowDialog(); // показываем//cохраняем данные в форме))

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //
        OleDbConnection con2 = new OleDbConnection("Provider=MSDAORA;Data Source=XE;Persist Security Info=True;User ID=coursework;Password=cw1;Unicode=True;");//connection beeywen oracle and c#
        //

        private void button2_Click(object sender, EventArgs e)
        {
            con2.Open();
            OleDbDataAdapter oda = new OleDbDataAdapter("select * from users", con2);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            con2.Close();
            dataGridView1.ReadOnly = true;           
        }

      

        private void button3_Click(object sender, EventArgs e)
           {
           
           }
        }
    }
