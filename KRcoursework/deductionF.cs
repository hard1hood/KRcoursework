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
    public partial class deductionF : Form
    {
        public deductionF()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            dianeryF f4 = new dianeryF();//create
            f4.ShowDialog(); // показываем
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        //
        OleDbConnection con2 = new OleDbConnection("Provider=MSDAORA;Data Source=XE;Persist Security Info=True;User ID=coursework;Password=cw1;Unicode=True;");//connection beeywen oracle and c#
        //
        private void deductionF_Load(object sender, EventArgs e)
        {

            
           
        }
    }
}
