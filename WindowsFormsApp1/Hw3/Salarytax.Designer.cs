﻿
namespace WindowsFormsApp1
{
    partial class Salarytax
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
            this.label1 = new System.Windows.Forms.Label();
            this.salarybox = new System.Windows.Forms.TextBox();
            this.bonusbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.spousebox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.childrenbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt2 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salary";
            // 
            // salarybox
            // 
            this.salarybox.Location = new System.Drawing.Point(103, 10);
            this.salarybox.Name = "salarybox";
            this.salarybox.Size = new System.Drawing.Size(314, 31);
            this.salarybox.TabIndex = 1;
            this.salarybox.Text = "0";
            this.salarybox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salarybox_KeyPress);
            // 
            // bonusbox
            // 
            this.bonusbox.Location = new System.Drawing.Point(103, 47);
            this.bonusbox.Name = "bonusbox";
            this.bonusbox.Size = new System.Drawing.Size(314, 31);
            this.bonusbox.TabIndex = 3;
            this.bonusbox.Text = "0";
            this.bonusbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salarybox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bonus";
            // 
            // spousebox
            // 
            this.spousebox.Location = new System.Drawing.Point(103, 94);
            this.spousebox.Name = "spousebox";
            this.spousebox.Size = new System.Drawing.Size(107, 31);
            this.spousebox.TabIndex = 5;
            this.spousebox.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Spouse";
            // 
            // childrenbox
            // 
            this.childrenbox.Location = new System.Drawing.Point(103, 131);
            this.childrenbox.Name = "childrenbox";
            this.childrenbox.Size = new System.Drawing.Size(107, 31);
            this.childrenbox.TabIndex = 7;
            this.childrenbox.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Children";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 65);
            this.button1.TabIndex = 8;
            this.button1.Text = "Caculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.txt2);
            this.panel1.Controls.Add(this.txt1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(18, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 159);
            this.panel1.TabIndex = 9;
            // 
            // txt2
            // 
            this.txt2.AutoSize = true;
            this.txt2.ForeColor = System.Drawing.Color.White;
            this.txt2.Location = new System.Drawing.Point(197, 85);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(24, 25);
            this.txt2.TabIndex = 11;
            this.txt2.Text = "0";
            this.txt2.Click += new System.EventHandler(this.txt2_Click);
            // 
            // txt1
            // 
            this.txt1.AutoSize = true;
            this.txt1.ForeColor = System.Drawing.Color.White;
            this.txt1.Location = new System.Drawing.Point(197, 13);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(24, 25);
            this.txt1.TabIndex = 12;
            this.txt1.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Last Salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tax";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 51);
            this.button2.TabIndex = 13;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(324, 349);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 51);
            this.button3.TabIndex = 14;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Salarytax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 433);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.childrenbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.spousebox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bonusbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.salarybox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Salarytax";
            this.Text = "Salarytax";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox salarybox;
        private System.Windows.Forms.TextBox bonusbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox spousebox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox childrenbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txt2;
        private System.Windows.Forms.Label txt1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}