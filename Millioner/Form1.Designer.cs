
namespace Millioner
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.QuestionBox = new System.Windows.Forms.TextBox();
            this.Ans1 = new System.Windows.Forms.Button();
            this.Ans2 = new System.Windows.Forms.Button();
            this.Ans3 = new System.Windows.Forms.Button();
            this.Ans4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.ForeColor = System.Drawing.Color.Orange;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 35;
            this.listBox1.Items.AddRange(new object[] {
            "15 - 1 000 000",
            "14 - 500 000",
            "13 - 250 000",
            "12 - 125 000",
            "11 - 64 000",
            "10 - 32 000",
            "9 - 16 000",
            "8 - 8 000",
            "7 - 4 000",
            "6 - 2 000",
            "5 - 1 000",
            "4 - 500",
            "3 - 300",
            "2 - 200",
            "1 - 100"});
            this.listBox1.Location = new System.Drawing.Point(588, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(206, 529);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.ForeColor = System.Drawing.Color.Wheat;
            this.groupBox1.Location = new System.Drawing.Point(588, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 63);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Подсказки";
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Millioner.Properties.Resources._3;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(145, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 33);
            this.button3.TabIndex = 0;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Millioner.Properties.Resources._2;
            this.button2.Location = new System.Drawing.Point(77, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 33);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Millioner.Properties.Resources._1;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(6, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 33);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QuestionBox
            // 
            this.QuestionBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.QuestionBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QuestionBox.ForeColor = System.Drawing.Color.Gold;
            this.QuestionBox.Location = new System.Drawing.Point(32, 334);
            this.QuestionBox.MaximumSize = new System.Drawing.Size(1000, 100);
            this.QuestionBox.Multiline = true;
            this.QuestionBox.Name = "QuestionBox";
            this.QuestionBox.ReadOnly = true;
            this.QuestionBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.QuestionBox.Size = new System.Drawing.Size(531, 77);
            this.QuestionBox.TabIndex = 1;
            this.QuestionBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Ans1
            // 
            this.Ans1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ans1.ForeColor = System.Drawing.Color.Gold;
            this.Ans1.Location = new System.Drawing.Point(32, 428);
            this.Ans1.Name = "Ans1";
            this.Ans1.Size = new System.Drawing.Size(213, 55);
            this.Ans1.TabIndex = 2;
            this.Ans1.Text = "A.";
            this.Ans1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Ans1.UseVisualStyleBackColor = false;
            this.Ans1.Click += new System.EventHandler(this.Ans1_Click);
            // 
            // Ans2
            // 
            this.Ans2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ans2.ForeColor = System.Drawing.Color.Gold;
            this.Ans2.Location = new System.Drawing.Point(350, 428);
            this.Ans2.Name = "Ans2";
            this.Ans2.Size = new System.Drawing.Size(213, 55);
            this.Ans2.TabIndex = 2;
            this.Ans2.Text = "B.";
            this.Ans2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Ans2.UseVisualStyleBackColor = false;
            this.Ans2.Click += new System.EventHandler(this.WrongAns);
            // 
            // Ans3
            // 
            this.Ans3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ans3.ForeColor = System.Drawing.Color.Gold;
            this.Ans3.Location = new System.Drawing.Point(32, 508);
            this.Ans3.Name = "Ans3";
            this.Ans3.Size = new System.Drawing.Size(213, 55);
            this.Ans3.TabIndex = 2;
            this.Ans3.Text = "C.";
            this.Ans3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Ans3.UseVisualStyleBackColor = false;
            this.Ans3.Click += new System.EventHandler(this.WrongAns);
            // 
            // Ans4
            // 
            this.Ans4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ans4.ForeColor = System.Drawing.Color.Gold;
            this.Ans4.Location = new System.Drawing.Point(350, 508);
            this.Ans4.Name = "Ans4";
            this.Ans4.Size = new System.Drawing.Size(213, 55);
            this.Ans4.TabIndex = 2;
            this.Ans4.Text = "D.";
            this.Ans4.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Ans4.UseVisualStyleBackColor = false;
            this.Ans4.Click += new System.EventHandler(this.WrongAns);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::Millioner.Properties.Resources._new;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(12, 30);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(52, 33);
            this.button5.TabIndex = 0;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::Millioner.Properties.Resources.Exit;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(84, 30);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(52, 33);
            this.button4.TabIndex = 0;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.ForeColor = System.Drawing.Color.Gold;
            this.button6.Location = new System.Drawing.Point(155, 30);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 33);
            this.button6.TabIndex = 2;
            this.button6.Text = "Stop";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(790, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(77, 20);
            this.toolStripMenuItem1.Text = "New Game";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.button5_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(98, 20);
            this.toolStripMenuItem2.Text = "Админ панель";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(94, 20);
            this.toolStripMenuItem3.Text = "О программе";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Millioner.Properties.Resources.mil;
            this.ClientSize = new System.Drawing.Size(790, 589);
            this.Controls.Add(this.Ans4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Ans3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.Ans2);
            this.Controls.Add(this.Ans1);
            this.Controls.Add(this.QuestionBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Кто хочет стать миллионером";
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox QuestionBox;
        private System.Windows.Forms.Button Ans1;
        private System.Windows.Forms.Button Ans2;
        private System.Windows.Forms.Button Ans3;
        private System.Windows.Forms.Button Ans4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    }
}

