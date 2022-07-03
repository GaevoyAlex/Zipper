using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Zipper
{
    public partial class MainForm1 : Form
    {


        public MainForm1()
        {
            InitializeComponent();
           
        }





        //Code
        private void button2_Click(object sender, EventArgs e)
        {
            string inputstring = enterbox.Text; 
            string text = inputstring;

            //выходная строка
            StringBuilder output = new StringBuilder();
            char[] output2 = new char[10000000];
            //счётчик совпадений символов
            int count = 0;
            string d = "";
            //данная переменная хранит информацию о текущем символе последовательности
            char currentSybmol = text[0];
            int frec = 0;
            foreach (char symbol in text)
            {
                frec++;
                //если нам встретился такой же символ, как и раньше, то просто увеличиваем счётчик
                if (symbol == currentSybmol)
                    count++;
                //иначе, записываем в выходную строку информацию о прочитанной последовательности
                //и обновляем значение счётчика и переменной, хранящей информацию о текущем символе последовательности
                else
                {
                    //output.Append(count + currentSybmol);
                    string b = Convert.ToString(output.Append(count + char.ConvertFromUtf32(currentSybmol)));

                    currentSybmol = symbol;
                    count = 1;
                    d += b;
                }


            }   //не забываем, что после окончания цикла у нас осталась цепочка, информацию о которой мы не добавили в ответ.

            //output.Append(count + currentSybmol);
            string a = Convert.ToString(output.Append(count + char.ConvertFromUtf32(currentSybmol)));

            resultbox.Text = a;


        }
        //Decode
        private void button4_Click_1(object sender, EventArgs e)
        {
            //В данной переменной хранится закодированный текст
            string text = resultbox.Text;

            //переменная, в которой хранится ответ
            StringBuilder output = new StringBuilder();
            //переменная, в которой формируется число
            StringBuilder number = new StringBuilder();

            //проходимся по всем символам в тексте
            foreach (char symbol in text)
            {
                //если встретили цифру, то добавляем её к number
                if (char.IsDigit(symbol))
                    number.Append(symbol);
                //иначе, добавляем к ответу сформированное число раз текущий символ
                else
                {
                    for (int i = 0; i < int.Parse(number.ToString()); i++)
                        output.Append(symbol);
                    number.Clear();
                }

            }
            string a = Convert.ToString(output);
            resultbox.Text = a;
        }
        private void button5_Click(object sender, EventArgs e)//save
        {
            //openFileDialog1.ShowDialog();
            //string filename = openFileDialog1.FileName;
            //openFileDialog1.InitialDirectory = "c:\\";
            //openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            //string readfile = File.ReadAllText(filename);






           





        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        public void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }
        private void Save_Click(object sender, EventArgs e)//Save file
        {
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, richTextBox1.Text);
            MessageBox.Show("Файл сохранен");
        }
        private void upload_file_Click(object sender, EventArgs e)//Upload file button
        {
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            string readfile = File.ReadAllText(filename);
            richTextBox1.Text = readfile;
        }

        private void Coding_Click(object sender, EventArgs e)//Button take text from field and compress symbols to RLE
        {
            string inputstring = richTextBox1.Text;
            string text = inputstring;
            StringBuilder output = new StringBuilder();
            char[] output2 = new char[10000000];
            int count = 0;
            string d = "";
            char currentSybmol = text[0];
            int frec = 0;
            foreach (char symbol in text)
            {
                frec++;
                if (symbol == currentSybmol)
                    count++;
                else
                {
                    
                    string b = Convert.ToString(output.Append(count + char.ConvertFromUtf32(currentSybmol)));
                    currentSybmol = symbol;
                    count = 1;
                    d += b;
                }


            }         
            string a = Convert.ToString(output.Append(count + char.ConvertFromUtf32(currentSybmol)));
            richTextBox1.Text = a;
        }

        private void Decode_Click(object sender, EventArgs e)//Button for decode RLE compresed symbols
        {
            string text = resultbox.Text;
            StringBuilder output = new StringBuilder();
            StringBuilder number = new StringBuilder();
            foreach (char symbol in text)
            { 
                if (char.IsDigit(symbol))
                    number.Append(symbol);
                else
                {
                    for (int i = 0; i < int.Parse(number.ToString()); i++)
                        output.Append(symbol);
                    number.Clear();
                }
            }
            string a = Convert.ToString(output);
            resultbox.Text = a;
        }

        private void label2_Click(object sender, EventArgs e)//Close label
        {
            this.Close();

        }
    }
}

    














