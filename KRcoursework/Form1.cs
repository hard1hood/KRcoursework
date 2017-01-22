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
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //OleDbConnection con = new OleDbConnection("Provider=MSDAORA;Data Source=XE;Persist Security Info=True;User ID=coursework;Password=cw1;Unicode=True");//connection beeywen oracle and c#
        
        private void button1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        //
        OleDbConnection con2 = new OleDbConnection("Provider=MSDAORA;Data Source=XE;Persist Security Info=True;User ID=coursework;Password=cw1;Unicode=True;");//connection beeywen oracle and c#
        //

                    
        public void loginB_Click_1(object sender, EventArgs e)
        {
            con2.Open();//первый con2 для проверки credentials
            OleDbCommand cmd = new OleDbCommand("select login,password from users where login='"+loginT.Text+"'"+" and password='"+passwordT.Text+"'", con2);
            //cmd.Parameters.Add("login", "'" + loginT.Text + "'"); // защита от иньекций, тестим пока без(не работает)
            //cmd.Parameters.Add("password", "'" + passwordT.Text + "'");
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            con2.Close();

            bool loginSuccessful = ((ds.Tables.Count > 0) && (ds.Tables[0].Rows.Count > 0));

            con2.Open();//возможно можно сделать с одним con2(этот для проверки поля subject if deanery - вход для другого юзера
            OleDbCommand cmdsubject = new OleDbCommand("select login,password from users where login='" + loginT.Text + "'"+" and password = '"+passwordT.Text+"' and subject='DEANERY'", con2);
            OleDbDataAdapter dasubject = new OleDbDataAdapter(cmdsubject);
            DataSet dssubject = new DataSet();
            dasubject.Fill(dssubject);
            con2.Close();

            bool deanerySuccessful = ((dssubject.Tables.Count > 0) && (dssubject.Tables[0].Rows.Count > 0));

            if (loginT.Text != "" && passwordT.Text != "" && loginT.Text.Length < 50 && passwordT.Text.Length < 50)
            {
                

                if (loginSuccessful) //проверка логина и пароля
                {

                    if (deanerySuccessful)
                    {
                        MessageBox.Show("Authentication succsessful!\nLogging in into Deanery`s account");
                        this.Hide();
                        dianeryF f4 = new dianeryF(); // создаем
                        f4.ShowDialog(); // показываем
                    }
                    else
                    {
                        MessageBox.Show("Authentication succsessful!\nLogging in into Teachers account");
                        this.Hide();
                        teacherF f3 = new teacherF();// создаем
                        f3.ShowDialog();// показываем
                    }
                }
                else
                {
                    //тут типа если не совпали пароли
                    MessageBox.Show("Check your login and password!");
                }
                con2.Close();//обязательно закрывать, иначе при нажатие на кнопку еще раз открывается поверх и возникает exception
            }
            else if (loginT.Text == "" || passwordT.Text == "")
                MessageBox.Show("Empty enter!");
            else
                MessageBox.Show("Enter should be less then 50 symbols!");
            
        }

        private void registrationB_Click(object sender, EventArgs e)
        {


            this.Hide();
            registerF f5 = new registerF();// создаем
            f5.ShowDialog();// показываем

        }
        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
