using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication30
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int a, b, c;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("عدد دوم را وارد کنید", "هشدار");

            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("عدد اول را وارد کنید", "هشدار");

            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("زمان را وارد کنید", "هشدار");

            }
            else if (textBox1.Text == textBox2.Text)
            {
               
                 MessageBox.Show("عدد اول نباید با عدد دوم برابر  باشد ", "هشدار");

            }
            else if (int.Parse(textBox1.Text)<int.Parse(textBox2.Text))
            {
                MessageBox.Show("   عدد اول از عدد دوم بزرگتر است  باید عدد دوم بزرگتر از عدد اول باشد", "هشدار");

            }
            else
            {
                bool ply = false;
                try
                {

                    a = int.Parse(textBox1.Text);
                    b = int.Parse(textBox2.Text);
                    c = int.Parse(textBox3.Text);
                    ply = true;
                }
                catch
                {
                    MessageBox.Show("مقدار باید عدد باشد", "هشدار");
                }
                Form1 f1 = new Form1();

                if (ply == true)
                {
                    f1.maxnumber = a;
                    f1.minnumber = b;
                    f1.tim = c;
                    f1.tim1 = c;
                    f1.ch = comboBox1.Text;
                    f1.Show();
                    this.Hide();
                }
                else
                {

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            panel1.Visible = true;

        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            panel1.Visible =false;
        }
    }
}
