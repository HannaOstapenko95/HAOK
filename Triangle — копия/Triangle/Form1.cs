using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle
{
    public partial class Form1 : Form
    {
        int a;
        int h;
        int b;
        int c;
        int P;
        int p;
        double g;
        float s;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception) { textBox1.Text = "NOT CORRECT"; }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                h = Convert.ToInt32(textBox2.Text);
            }
            catch (Exception) { textBox2.Text = "NOT"; }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Convert.ToString(a));
            //label1.Text = "ret";
            try
            {

                s = (a * h) / 2;
                P = a + b + c;
            }
            catch
            {
                Console.WriteLine("Возникло исключение!");
            }
            label1.Text = Convert.ToString(s);
            label6.Text = "=" + Convert.ToString(a);
            label7.Text = "=" + Convert.ToString(h);
            label11.Text = Convert.ToString(P);
            label12.Text = Convert.ToString(b);
            label13.Text = Convert.ToString(c);
            p = P / 2;
            g = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            label15.Text = Convert.ToString(g);
            }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try { 
            b = Convert.ToInt32(textBox3.Text);
                }
            catch (Exception) { textBox3.Text = "NOT RIGHT"; }
}

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try { 
            c = Convert.ToInt32(textBox4.Text);
                }
            catch (Exception) { textBox4.Text = "NOT"; }
}
    }
}
