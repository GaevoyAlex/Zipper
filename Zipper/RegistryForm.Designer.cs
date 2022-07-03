namespace Zipper
{
    partial class RegistryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.verifyBut = new System.Windows.Forms.Button();
            this.NametextBox1 = new System.Windows.Forms.TextBox();
            this.SurnameBox2 = new System.Windows.Forms.TextBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.registrationBut = new System.Windows.Forms.Button();
            this.LoginBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // verifyBut
            // 
            this.verifyBut.Location = new System.Drawing.Point(12, 247);
            this.verifyBut.Name = "verifyBut";
            this.verifyBut.Size = new System.Drawing.Size(118, 23);
            this.verifyBut.TabIndex = 0;
            this.verifyBut.Text = "Назад";
            this.verifyBut.UseVisualStyleBackColor = true;
            this.verifyBut.Click += new System.EventHandler(this.verifyBut_Click);
            // 
            // NametextBox1
            // 
            this.NametextBox1.Location = new System.Drawing.Point(12, 62);
            this.NametextBox1.Name = "NametextBox1";
            this.NametextBox1.Size = new System.Drawing.Size(153, 20);
            this.NametextBox1.TabIndex = 1;
            this.NametextBox1.Enter += new System.EventHandler(this.NametextBox1_Enter);
            this.NametextBox1.Leave += new System.EventHandler(this.NametextBox1_Leave);
            // 
            // SurnameBox2
            // 
            this.SurnameBox2.Location = new System.Drawing.Point(12, 98);
            this.SurnameBox2.Name = "SurnameBox2";
            this.SurnameBox2.Size = new System.Drawing.Size(169, 20);
            this.SurnameBox2.TabIndex = 2;
            this.SurnameBox2.Enter += new System.EventHandler(this.SurnameBox2_Enter);
            this.SurnameBox2.Leave += new System.EventHandler(this.SurnameBox2_Leave);
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(12, 212);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(153, 20);
            this.PassBox.TabIndex = 3;
            this.PassBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.PassBox.Enter += new System.EventHandler(this.PassBox_Enter);
            this.PassBox.Leave += new System.EventHandler(this.PassBox_Leave);
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(12, 135);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(180, 20);
            this.EmailBox.TabIndex = 4;
            this.EmailBox.Enter += new System.EventHandler(this.EmailBox_Enter);
            this.EmailBox.Leave += new System.EventHandler(this.EmailBox_Leave);
            // 
            // registrationBut
            // 
            this.registrationBut.Location = new System.Drawing.Point(213, 247);
            this.registrationBut.Name = "registrationBut";
            this.registrationBut.Size = new System.Drawing.Size(140, 23);
            this.registrationBut.TabIndex = 5;
            this.registrationBut.Text = "Зарегистрироваться";
            this.registrationBut.UseVisualStyleBackColor = true;
            this.registrationBut.Click += new System.EventHandler(this.registrationBut_Click);
            // 
            // LoginBox3
            // 
            this.LoginBox3.Location = new System.Drawing.Point(12, 174);
            this.LoginBox3.Name = "LoginBox3";
            this.LoginBox3.Size = new System.Drawing.Size(169, 20);
            this.LoginBox3.TabIndex = 6;
            this.LoginBox3.Enter += new System.EventHandler(this.LoginBox3_Enter);
            this.LoginBox3.Leave += new System.EventHandler(this.LoginBox3_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(118, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Регистрация\r\n";
            // 
            // RegistryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 288);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginBox3);
            this.Controls.Add(this.registrationBut);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.SurnameBox2);
            this.Controls.Add(this.NametextBox1);
            this.Controls.Add(this.verifyBut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistryForm";
            this.Text = "RegistryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button verifyBut;
        private System.Windows.Forms.TextBox NametextBox1;
        private System.Windows.Forms.TextBox SurnameBox2;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Button registrationBut;
        private System.Windows.Forms.TextBox LoginBox3;
        private System.Windows.Forms.Label label1;
    }
}