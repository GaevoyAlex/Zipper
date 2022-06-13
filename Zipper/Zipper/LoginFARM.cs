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
    public partial class LoginFARM : Form
    {
        public LoginFARM()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            BackColor = Color.Transparent;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//Enter to email
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)//Password line
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void button2_Click(object sender, EventArgs e)//NoReg
        {
            this.Hide();
            MainForm1 registerform = new MainForm1();
            registerform.Show();
        }
    }
}
