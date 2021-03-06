﻿using System;
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
    public partial class registerStudentF : Form
    {
        public registerStudentF()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            dianeryF f1 = new dianeryF();
            f1.ShowDialog();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit(); 
            
        }

        //
        OleDbConnection conR = new OleDbConnection("Provider=MSDAORA;Data Source=XE;Persist Security Info=True;User ID=coursework;Password=cw1;Unicode=True;");//connection beeywen oracle and c#
        OleDbConnection con2 = new OleDbConnection("Provider=MSDAORA;Data Source=XE;Persist Security Info=True;User ID=coursework;Password=cw1;Unicode=True;");//connection beeywen oracle and c#
        //

        private void addB_Click(object sender, EventArgs e)
        {
            bool regCompleted = true;
            Check check = new Check();

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

            if (!check.checkLen(thirdnameT.Text))//група
            {
                label3.ForeColor = Color.IndianRed;
                regCompleted = false;
            }
            else
                label3.ForeColor = Color.ForestGreen;

            if (!check.checkLen(workbookT.Text))//зачетка
            {
                label4.ForeColor = Color.IndianRed;
                regCompleted = false;
            }
            else
                label4.ForeColor = Color.ForestGreen;

            if (regCompleted)
            {

                //MessageBox.Show("Success!");

                con2.Open();


                try
                {
                    OleDbCommand ins = new OleDbCommand("insert into students values('" + workbookT.Text + "','" + nameT.Text + "','" + lastnameT.Text + "','" + thirdnameT.Text + "')", con2);
                    ins.ExecuteNonQuery();

                    OleDbCommand instS = new OleDbCommand("INSERT INTO Timesheet VALUES('1', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '','" + workbookT.Text + "')", con2);
                    instS.ExecuteNonQuery();
                    
                    
                   

                    label10.Text = "Success!";
                    label10.Visible = true;
                    label10.ForeColor = Color.ForestGreen;



                }
                catch
                {
                    //MessageBox.Show("Для поля номер трудовоi та/або login необхiдно вказати унiкальне значення");
                    label10.ForeColor = Color.IndianRed;
                    label10.Text = "Для поля номер трудовоi та/або login необхiдно вказати унiкальне значення";
                }
                con2.Close();



            }
            else
            {
                label10.Text = "Вказанi невалiднi данi!";
                //MessageBox.Show("Вказанi невалiднi данi!");
                label10.ForeColor = Color.IndianRed;
                label10.Visible = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();//не прячем жту форму чтобы сохранить поля
            studentListF f2 = new studentListF(); // создаем
            f2.ShowDialog(); // показываем
        }
    }
}
