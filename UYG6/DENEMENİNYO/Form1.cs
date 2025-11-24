using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DENEMENİNYO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label2.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label2.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label2.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label2.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label2.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
        {
            if (label2.Text.Length > 1)
            {
                // 
                label2.Text = label2.Text.Substring(0, label2.Text.Length - 1);
            }
            else
            {
                // 
                label2.Text = "0";
            }
        }

    }

        private void button12_Click(object sender, EventArgs e)
        {
            // 
            listBox1.Items.Add(label2.Text);

            // 
            label2.Text = "0";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
