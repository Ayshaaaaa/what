using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApplication30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public int maxnumber, minnumber,tim,tim1;
        public string ch;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            progressBar1.Value = tim;
            progressBar1.Maximum = tim1;
            progressBar1.Minimum =0;
            add();
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                tim--;
                progressBar1.Value = tim;
            }
            catch
            {
                timer1.Enabled = false;
                MessageBox.Show("مدت زمان شما تمام شد دباره تلاش کنید","هشدار");

                this.Hide();
                
                Form2 f2 = new Form2();
                f2.Show();
            }
        }

        float a, b;
        float sum;


        private void add()
        {
            Random r = new Random();
            a = r.Next(minnumber,maxnumber);
            b = r.Next(minnumber,maxnumber);
            label1.Text = a.ToString();
            label2.Text = b.ToString();
            if (ch == "*")
            {
                label3.Text = "*";
                sum = a * b;
                
            }
            if (ch == "+")
            {
                label3.Text = "+";
                sum = a+ b;

            }
            if (ch == "-")
            {
                label3.Text = "-";
                sum = a - b;
            }
            if (ch == "/")
            {
                label3.Text = "/";
                sum = a / b;
            }

        }
        int m;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == sum.ToString())
            {
                progressBar1.Value = tim1;
                tim = tim1;
                SoundPlayer ply = new SoundPlayer();
                ply.PlayLooping();
                textBox1.Clear();
                add();
                m++;
                this.Text = m + "   :سطح پیشرفت شما  ";
                 
               
               
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("0");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        
    }
}
