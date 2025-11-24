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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s1, s2, s3, ort;
            s1=Convert.ToDouble(textBox1.Text);
            s2=Convert.ToDouble(textBox2.Text);
            s3=Convert.ToDouble(textBox3.Text);

            ort = (s1 + s2 + s3) / 3;
                label4.Text =ort.ToString();
        }
    }
}
