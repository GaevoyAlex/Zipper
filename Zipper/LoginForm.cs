using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zipper
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            
        }
       
        private void label2_Click(object sender, EventArgs e)
        {
            BackColor = Color.Transparent;
        }

        private void button2_Click(object sender, EventArgs e)//NoReg
        {
            this.Hide();
            MainForm1 registerform = new MainForm1();
            registerform.Show();
        }
        private void button1_Click_1(object sender, EventArgs e)//Кнопка отправки заполненых полей
        { 
            string log = enterLogin.Text;//Поле с вводом логина
            string pass = enterPasword.Text;//поле с с вводом пароля 
            
            DB db = new DB();

            DataTable dt = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MainForm1 registerform = new MainForm1();
            MySqlCommand comand = new MySqlCommand("SELECT * FROM `userbase` WHERE `Login` = @L AND `Pasword` = @P", db.getConnection());//Отправка данных в бд
            comand.Parameters.Add("@L",MySqlDbType.VarChar).Value = log;
            comand.Parameters.Add("@P", MySqlDbType.VarChar).Value = pass;


            adapter.SelectCommand = comand;
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)//Проверка пользователя в базе данных
            {

                this.Hide();
                registerform.Show();//переход на главную форму
            }

            else
            {
                MessageBox.Show("Зарегестрируйтесь");//Вывод окна с сообщением
            }
        }

        private void Registry_Click(object sender, EventArgs e)//Регистрация
        {
            this.Hide();
            RegistryForm registform = new RegistryForm();
            registform.Show();

        }
         private void label1_Click(object sender, EventArgs e)
         {

         }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {
           
        } 
        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void Login_TextChanged(object sender, EventArgs e)
        {

        }

        public void Pasword(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        private void enterLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
