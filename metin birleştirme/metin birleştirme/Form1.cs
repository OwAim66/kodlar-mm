using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metin_birleştirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 x = new Form2();
            x.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad,soyad,tammetin;
            ad=textBox1.Text;
            soyad=textBox2.Text;
            tammetin = ad + " " + soyad;
            textBox3.Text = tammetin;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
