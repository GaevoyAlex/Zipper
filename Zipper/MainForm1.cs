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






        private void button2_Click(object sender, EventArgs e)
        {


            /*Console.WriteLine("Please enter the string:");
            string input = Console.ReadLine();*/
            //openFileDialog1.ShowDialog();
            //string filename = openFileDialog1.FileName;
            //openFileDialog1.InitialDirectory = "c:\\";
            //openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            //string readfile = File.ReadAllText(filename);

            Huffman hufman = new Huffman();

            hufman.CompressFiles("Новый текстовый документ.txt", "compressCompress.txt");


            // Build the Huffman tree


            // Encode


        }
            private void button1_Click(object sender, EventArgs e)
            {
                richTextBox1.SaveFile(System.Environment.GetFolderPath
                    (System.Environment.SpecialFolder.Personal)
                    + @"\Zip1.txt",
                       RichTextBoxStreamType.RichNoOleObjs);
            }





        private void button5_Click(object sender, EventArgs e)
        {
            //openFileDialog1.ShowDialog();
            //string filename = openFileDialog1.FileName;
            //openFileDialog1.InitialDirectory = "c:\\";
            //openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            //string readfile = File.ReadAllText(filename);
            
           
            

            Huffman hufman = new Huffman();

            hufman.DecompressFile ("Новый текстовый документ.txt", "decompressCompress.txt");



            // Decode

           



        }
    } 
}
    














