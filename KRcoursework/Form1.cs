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
            this.Hide();
            Form2 f2 = new Form2(); // создаем
            f2.ShowDialog(); // показываем
            
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
            String loginS = loginT.Text;


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
            OleDbCommand cmdsubject = new OleDbCommand("select subject from users where login='" + loginT.Text + "'", con2);
            bool deanerySuccessful = ((ds.Tables.Count > 0) && (ds.Tables[0].Rows.Count > 0));
            OleDbDataAdapter dasubject = new OleDbDataAdapter(cmdsubject);
            DataSet dssubject = new DataSet();
            da.Fill(dssubject);
            con2.Close();



            if (loginT.Text != "" && passwordT.Text != "" && loginT.Text.Length < 50 && passwordT.Text.Length < 50)
            {
                con2.Open();
                /*OleDbDataAdapter subject = new OleDbDataAdapter("select subject from users where login=?", con2);
                subject.SelectCommand.Parameters.AddWithValue("p1", "'"+loginT.Text+"'");
                /*
                OleDbDataAdapter log = new OleDbDataAdapter("select login from users where login=?", con2);
                log.SelectCommand.Parameters.AddWithValue("p2", "'" + loginT.Text + "'");
                OleDbDataAdapter pass = new OleDbDataAdapter("select password from users where login=?", con2);
                pass.SelectCommand.Parameters.AddWithValue("p3", "'" + loginT.Text + "'");
                */
                
                if (loginSuccessful) //проверка логина и пароля
                {
                    MessageBox.Show("Authentication succsessful!");

                    if (deanerySuccessful)
                    {
                        MessageBox.Show("Deanery account incoming!");
                        this.Hide();
                        dianeryF f4 = new dianeryF(); // создаем
                        f4.ShowDialog(); // показываем
                    }
                    else
                    {
                        MessageBox.Show("teachers account incoming!");
                        this.Hide();
                        teacherF f3 = new teacherF();// создаем
                        f3.ShowDialog();
                    }
                }
                else
                {
                    //тут типа если не совпали пароли
                    MessageBox.Show("Check your login and password!");
                }
                con2.Close();//обязательно закрывать, иначе при нажатие на кнопку еще раз открывается поверх и возникает exception
            }
            else if (loginT.Text == "" && passwordT.Text == "")
                MessageBox.Show("Empty enter!");
            else
                MessageBox.Show("Enter should be less then 50 symbols!");
            
        }

        private void registrationB_Click(object sender, EventArgs e)
        {

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
