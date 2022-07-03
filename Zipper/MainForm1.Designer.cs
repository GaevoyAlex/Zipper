using System;

namespace Zipper
{
    partial class MainForm1
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
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.enterbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.resultbox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.upload_file = new System.Windows.Forms.Button();
            this.Coding = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Decode = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(316, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 25);
            this.button2.TabIndex = 2;
            this.button2.Text = "Code";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "TextFile";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Result of compress.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // enterbox
            // 
            this.enterbox.Location = new System.Drawing.Point(147, 223);
            this.enterbox.Name = "enterbox";
            this.enterbox.Size = new System.Drawing.Size(310, 20);
            this.enterbox.TabIndex = 10;
            this.enterbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Enter your text.";
            // 
            // resultbox
            // 
            this.resultbox.Location = new System.Drawing.Point(147, 280);
            this.resultbox.Name = "resultbox";
            this.resultbox.Size = new System.Drawing.Size(310, 20);
            this.resultbox.TabIndex = 16;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(316, 306);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 24);
            this.button4.TabIndex = 18;
            this.button4.Text = "Decode";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // upload_file
            // 
            this.upload_file.Location = new System.Drawing.Point(5, 77);
            this.upload_file.Name = "upload_file";
            this.upload_file.Size = new System.Drawing.Size(99, 23);
            this.upload_file.TabIndex = 19;
            this.upload_file.Text = "Choose file";
            this.upload_file.UseVisualStyleBackColor = true;
            this.upload_file.Click += new System.EventHandler(this.upload_file_Click);
            // 
            // Coding
            // 
            this.Coding.Location = new System.Drawing.Point(5, 183);
            this.Coding.Name = "Coding";
            this.Coding.Size = new System.Drawing.Size(152, 23);
            this.Coding.TabIndex = 20;
            this.Coding.Text = "Code";
            this.Coding.UseVisualStyleBackColor = true;
            this.Coding.Click += new System.EventHandler(this.Coding_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(110, 22);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(347, 155);
            this.richTextBox1.TabIndex = 21;
            this.richTextBox1.Text = "";
            // 
            // Decode
            // 
            this.Decode.Location = new System.Drawing.Point(322, 183);
            this.Decode.Name = "Decode";
            this.Decode.Size = new System.Drawing.Size(135, 23);
            this.Decode.TabIndex = 22;
            this.Decode.Text = "Decode";
            this.Decode.UseVisualStyleBackColor = true;
            this.Decode.Click += new System.EventHandler(this.Decode_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(184, 183);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(116, 23);
            this.Save.TabIndex = 23;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(462, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // MainForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(479, 342);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Decode);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Coding);
            this.Controls.Add(this.upload_file);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.resultbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.enterbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(16, 39);
            this.Name = "MainForm1";
            this.Text = "MainForm1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        



        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox enterbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox resultbox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button upload_file;
        private System.Windows.Forms.Button Coding;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Decode;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label2;
    }
}