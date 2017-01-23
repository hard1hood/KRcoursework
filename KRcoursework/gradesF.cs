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
            con2.Open();
            OleDbDataAdapter oda = new OleDbDataAdapter("SELECT ", FirstName,LastName, Subject(предмет,который ведет этот препод) From ShowStudMarks Order by SrGroup, FirstName, LastName; ", con2);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            dataGridView1.DataSource = dt;
            con2.Close();
            dataGridView1.ReadOnly = true;
        }
    }
}
