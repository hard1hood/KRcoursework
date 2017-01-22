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

            if (!check.checkLen(workbookT.Text))//trudovaya
            {
                label4.ForeColor = Color.IndianRed;
                regCompleted = false;
            }
            else
                label4.ForeColor = Color.ForestGreen;
            try
            {
                if (!check.CheckName(comboBoxSubj.SelectedItem.ToString()))//predmet

                {
                    label11.ForeColor = Color.IndianRed;
                    regCompleted = false;
                }
                        else
                label11.ForeColor = Color.ForestGreen;
            }
            catch
            {
                MessageBox.Show("Оберiть, будь-ласка, предмет");
            }


            if (!check.checkLen(loginT.Text))//login
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

            if (!check.CheckPass(passT.Text) || !check.checkLen(passT.Text))//password
            {
                label7.ForeColor = Color.IndianRed;
                regCompleted = false;
            }
            else
                label7.ForeColor = Color.ForestGreen;

            if (!check.CheckPass(confpassT.Text) || !check.PassConfirm(passT.Text, confpassT.Text))//check password
            {
                label8.ForeColor = Color.IndianRed;
                regCompleted = false;
            }
            else
                label8.ForeColor = Color.ForestGreen;

            if (regCompleted)
            {
                
                MessageBox.Show("Success!");
                //label10.ForeColor = Color.ForestGreen;
                label10.Visible = false;
                conR.Open();
                
                try
                {
                    OleDbCommand ins = new OleDbCommand("insert into users values('" + workbookT.Text + "','" + comboBoxSubj.SelectedItem.ToString() + "','" + nameT.Text + "','" + lastnameT.Text + "','" + thirdnameT.Text + "','" + emailT.Text + "','" + loginT.Text + "','" + passT.Text + "')", conR);
                    ins.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Для поля номер трудовоi та/або login необхiдно вказати унiкальне значення");
                }
                conR.Close();
            }
            else
            {
                label10.Text = "Вказанi невалiднi данi!";
                //MessageBox.Show("Вказанi невалiднi данi!");
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

        /*private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           if( checkBox1.Checked) { .Text = "DEANERY"; subjectT.ReadOnly=true; } else { subjectT.ReadOnly = false; }
           //поле предмет становится неактивным и в него вписывается 'DEANERY'
        }
        */
        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();//не прячем жту форму чтобы сохранить поля
            Form2 f2 = new Form2(); // создаем
            f2.ShowDialog(); // показываем
        }
    }
}
