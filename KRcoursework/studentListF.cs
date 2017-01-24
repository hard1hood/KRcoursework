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
    public partial class studentListF : Form
    {
        public studentListF()
        {
            InitializeComponent();
        }

        //
        OleDbConnection con2 = new OleDbConnection("Provider=MSDAORA;Data Source=XE;Persist Security Info=True;User ID=coursework;Password=cw1;Unicode=True;");//connection beeywen oracle and c#
        //

        private void button2_Click(object sender, EventArgs e)
        {
            con2.Open();
            OleDbDataAdapter oda = new OleDbDataAdapter("select N_trud, Subject, FirstName, LastName, Patronymic, Email from users", con2);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            con2.Close();
            dataGridView1.ReadOnly = true;
        }
    }
}
