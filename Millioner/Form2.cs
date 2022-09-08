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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(comboBox1.SelectedItem);
            string []newquestion = { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text };
            string str = "";
            int counter = 5;
            StreamReader sr = new StreamReader("question.txt", Encoding.UTF8);
            while(sr.Peek() != -1)
            {
                if (counter / 5 == num)
                {
                    str += newquestion[counter % 5] + '\n';
                    sr.ReadLine();
                }
                else
                {
                    str += sr.ReadLine() + '\n';
                }
                counter++;
            }
            sr.Close();
            StreamWriter sw = new StreamWriter("question.txt", false);
            sw.Write(str);
            sw.Close();
        }
    }
}
