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
    public partial class RegistryForm : Form
    {
        public RegistryForm()
        {
            InitializeComponent();//переменные для обработчика событий
            NametextBox1.Text = "Введите имя";
            NametextBox1.ForeColor = Color.Gray;    
            SurnameBox2.Text = "Введите фамилию";
            SurnameBox2.ForeColor = Color.Gray;
            EmailBox.Text = "Введите email";
            EmailBox.ForeColor = Color.Gray;
            LoginBox3.Text = "Введите логин";
            LoginBox3.ForeColor = Color.Gray;
            PassBox.Text = "Введите пароль";
            PassBox.ForeColor = Color.Gray;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void verifyBut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginform = new LoginForm();
            loginform.Show();
        }

        private void NametextBox1_Enter(object sender, EventArgs e)
        {
            if(NametextBox1.Text== "Введите имя")
            NametextBox1.Text = "";
        }
        private void NametextBox1_Leave(object sender, EventArgs e)
        {
            if (NametextBox1.Text == "")
                NametextBox1.Text = "Введите имя";
        }
        private void SurnameBox2_Enter(object sender, EventArgs e)
        {
            if (SurnameBox2.Text == "Введите фамилию")
                SurnameBox2.Text = "";
        }
        private void SurnameBox2_Leave(object sender, EventArgs e)
        {
            if (SurnameBox2.Text == "")
                SurnameBox2.Text = "Введите фамилию";
        }
        private void EmailBox_Leave(object sender, EventArgs e)
        {
            if (EmailBox.Text == "")
                EmailBox.Text = "Введите email";
        }
        private void EmailBox_Enter(object sender, EventArgs e)
        {
            if (EmailBox.Text == "Введите email")
                EmailBox.Text = "";
        }
        private void LoginBox3_Enter(object sender, EventArgs e)
        {
            if (LoginBox3.Text == "Введите логин")
                LoginBox3.Text = "";
        }
        private void LoginBox3_Leave(object sender, EventArgs e)
        {
            if (LoginBox3.Text == "")
                LoginBox3.Text = "Введите логин";
        }
        private void PassBox_Enter(object sender, EventArgs e)
        {
            if (PassBox.Text == "Введите пароль")
                PassBox.Text = "";
        }
        private void PassBox_Leave(object sender, EventArgs e)
        {
            if (PassBox.Text == "")
                PassBox.Text = "Введите пароль";
        }

        private void registrationBut_Click(object sender, EventArgs e)
        {//проверка на входные данные
            if (LoginBox3.Text == "Введите имя")
            {
                MessageBox.Show("Введите имя");
                return;
            }
            if (PassBox.Text == "Введите пароль")
            {
                MessageBox.Show("Введите пароль");
                return;
            }
            if (NametextBox1.Text == "Введите имя")
            {
                MessageBox.Show("Введите имя");
                return;
            }
            if (SurnameBox2.Text == "Введите фамилию")
            {
                MessageBox.Show("Введите фамилию");
                return; 
            }
            if(EmailBox.Text =="Введите email")
            {
                return;
            }

            if (CheckLogin())
            {
                return;
            }
            //отправка всех данных
            DB db = new DB();
            MySqlCommand comand = new MySqlCommand("INSERT INTO `userbase` (`ID`, `Login`, `Pasword`, `UserName`, `UserSurname`) VALUES(NULL, @l, @pass, @name, @surname)",db.getConnection());

            comand.Parameters.Add("@l", MySqlDbType.VarChar).Value = LoginBox3.Text;
            comand.Parameters.Add("@pass", MySqlDbType.VarChar).Value = PassBox.Text;
            comand.Parameters.Add("@name", MySqlDbType.VarChar).Value = NametextBox1.Text;
            comand.Parameters.Add("@surname", MySqlDbType.VarChar).Value = SurnameBox2.Text;

            db.Openconection();
            //проверка на успешность регистрации
            if (comand.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт создан");

            
            else
                MessageBox.Show("Не удалось создать" +
                    "аккаунт");

            db.Closeconection();
        }
        public Boolean CheckLogin()//проверка на повторимость логина
        {
            DB db = new DB();

            DataTable dt = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MainForm1 registerform = new MainForm1();
            MySqlCommand comand = new MySqlCommand("SELECT * FROM `userbase` WHERE `Login` = @L", db.getConnection());
            comand.Parameters.Add("@L", MySqlDbType.VarChar).Value = LoginBox3.Text;



            adapter.SelectCommand = comand;
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже занят, введите другой.");
                return true;
            }

            else
            {
                MessageBox.Show("Успешно");
                return false;
            }
        }
    }
}
