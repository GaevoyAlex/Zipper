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

       

        
        public void button1_Click(object sender, EventArgs e)
        {


            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            string readfile = File.ReadAllText(filename);
            richTextBox1.Text = readfile;
            
            
        }
        
        
    }
}


         

    
     

    

    
