using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HER_ZAMAN_GENÇ_VE_GÜZELSİN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("KAYDETMEK İSTİYONMU ", "KAYDET", MessageBoxButtons.YesNoCancel);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "HER ZAMAN GENÇ VE GÜZELSİN";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
