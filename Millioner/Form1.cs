using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Millioner
{
    public partial class Form1 : Form
    {
        bool hint1 = false;
        bool hint2 = false;
        bool hint3 = false;
        int answernum = 1;
        StreamReader sr = new StreamReader("question.txt", Encoding.UTF8);

        public Form1()
        {
            InitializeComponent();
            listBox1.SelectedItem = listBox1.Items[listBox1.Items.Count - answernum];
            QuestionBox.Text = sr.ReadLine();
            Ans1.Text += sr.ReadLine();
            Ans2.Text += sr.ReadLine();
            Ans3.Text += sr.ReadLine();
            Ans4.Text += sr.ReadLine();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (hint1)
            {

            }
            else
            {
                hint1 = true;
                Ans2.Text = "B.";
                Ans3.Text = "C.";
                button1.Image = Image.FromFile("4.jpg");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (hint2)
            {

            }
            else
            {
                MessageBox.Show("Звоним другу");
                MessageBox.Show($"Думаю, что правильный ответ: {Ans1.Text}");
                hint2 = true;
                button2.Image = Image.FromFile("5.jpg");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (hint3)
            {
            }
            else
            {
                hint3 = true;
                button3.Image = Image.FromFile("6.jpg");
            }
        }

        private void Ans1_Click(object sender, EventArgs e)
        {
            QuestionBox.Text = sr.ReadLine();
            answernum++;
            if (answernum == 16)
            {
                MessageBox.Show("You win!");
                Application.Exit();
            }
            listBox1.SelectedItem = listBox1.Items[listBox1.Items.Count - answernum];
            Ans1.Text = Ans1.Text[0].ToString() + Ans1.Text[1].ToString() + sr.ReadLine();
            Ans2.Text = Ans2.Text[0].ToString() + Ans2.Text[1].ToString() + sr.ReadLine();
            Ans3.Text = Ans3.Text[0].ToString() + Ans3.Text[1].ToString() + sr.ReadLine();
            Ans4.Text = Ans4.Text[0].ToString() + Ans4.Text[1].ToString() + sr.ReadLine();
        }

        private void WrongAns(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            answernum = 1;
            listBox1.SelectedItem = listBox1.Items[listBox1.Items.Count - answernum];
            sr.Close();
            sr = new StreamReader("question.txt", Encoding.UTF8);
            QuestionBox.Text = sr.ReadLine();
            Ans1.Text = Ans1.Text[0].ToString() + Ans1.Text[1].ToString() + sr.ReadLine();
            Ans2.Text = Ans2.Text[0].ToString() + Ans2.Text[1].ToString() + sr.ReadLine();
            Ans3.Text = Ans3.Text[0].ToString() + Ans3.Text[1].ToString() + sr.ReadLine();
            Ans4.Text = Ans4.Text[0].ToString() + Ans4.Text[1].ToString() + sr.ReadLine();
            button1.Image = Image.FromFile("1.jpg");
            button2.Image = Image.FromFile("2.jpg");
            button3.Image = Image.FromFile("3.jpg");
            hint1 = false;
            hint2 = false;
            hint3 = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (answernum > 1)
            {
                string str = listBox1.Items[listBox1.Items.Count - answernum + 1].ToString();
                MessageBox.Show($"Вы остановились на вопросе {str[0].ToString() + str[1].ToString()} ");
                Application.Exit();
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("О программе");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            sr.Close();
            Form2 f = new Form2();
            f.ShowDialog();
        }
    }
}
