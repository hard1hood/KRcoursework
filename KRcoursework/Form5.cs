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
    public partial class registerF : Form
    {
        Check check = new Check();
        public registerF()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            dianeryF f4 = new dianeryF();//create
            f4.ShowDialog(); // показываем
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        //
        OleDbConnection conR = new OleDbConnection("Provider=MSDAORA;Data Source=XE;Persist Security Info=True;User ID=coursework;Password=cw1;Unicode=True;");//connection beeywen oracle and c#
        //

        private void addB_Click(object sender, EventArgs e)
        {
            bool regCompleted = true;
            

            if (!check.CheckName(lastnameT.Text))//фамилия  
            {
                label1.ForeColor = Color.IndianRed;
                regCompleted = false;
            }
            else
                label1.ForeColor = Color.ForestGreen;

            if (!check.CheckName(nameT.Text))//имя
            {
                label2.ForeColor = Color.IndianRed;
                regCompleted = false;
            }
            else
                label2.ForeColor = Color.ForestGreen;

            if (!check.CheckName(thirdnameT.Text))//po batkovi
            {
                label3.ForeColor = Color.IndianRed;
                regCompleted = false;
            }
            else
                label3.ForeColor = Color.ForestGreen;

            if (!check.CheckName(workbookT.Text))//trudovaya
            {
                label4.ForeColor = Color.IndianRed;
                regCompleted = false;
            }
            else
                label4.ForeColor = Color.ForestGreen;

            if (!check.CheckName(loginT.Text))//login
            {
                label5.ForeColor = Color.IndianRed;
                regCompleted = false;
            }
            else
                label5.ForeColor = Color.ForestGreen;

            if (!check.IsValidEmail(emailT.Text))//email-regexp check
            {
                label6.ForeColor = Color.IndianRed;
                regCompleted = false;
            }
            else
                label6.ForeColor = Color.ForestGreen;

            if (!check.CheckPass(passT.Text))//password
            {
                label7.ForeColor = Color.IndianRed;
                label8.ForeColor = Color.IndianRed;
                regCompleted = false;
            }
            else
                label7.ForeColor = Color.ForestGreen;

            if ((!check.PassConfirm(passT.Text, confpassT.Text)) && (!check.CheckPass(confpassT.Text)))//check password
            {
                label8.ForeColor = Color.IndianRed;
                regCompleted = false;
            }
            else
                label8.ForeColor = Color.ForestGreen;
                label7.ForeColor = Color.ForestGreen;

            if (regCompleted)
            {
                
                label10.Text = "Success!";
                label10.ForeColor = Color.ForestGreen;
                label10.Visible = true;
                

            }
            else
            {
                label10.Text = "Вказанi невалiднi данi!";
                label10.ForeColor = Color.IndianRed;
                label10.Visible = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void registerF_Load(object sender, EventArgs e)
        {
            
        }
    }
}
