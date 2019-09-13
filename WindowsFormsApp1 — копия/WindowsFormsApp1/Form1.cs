using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Threading;
using System.Diagnostics;
using ExcelApp = Microsoft.Office.Interop.Excel;
//using System.Runtime.InteropServices;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //[DllImport("user32.dll")]
        //static extern IntPtr SetParent(IntPtr hwc, IntPtr hwp);
        private void button1_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text;
            MessageBox.Show(name);
            //ProcessStartInfo startInfo = new ProcessStartInfo();
            //startInfo.FileName = @"C:\some_location\myapplication.exe";
            //startInfo.Arguments = "header.h";
            //Process.Start(startInfo);
            //Process.Start(@"C:\some_location\myapplication.exe");
            Process p = Process.Start("ConsoleApp1.exe");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string test = listBox1.GetItemText(listBox1.SelectedItem);
            MessageBox.Show(test);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
