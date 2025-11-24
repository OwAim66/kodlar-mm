using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama_27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int say = 1;
            while (say <= 10)
            {
                listBox1.Items.Add(say);
                say++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int dongu_say = 1;
            int toplam = 0;
            while (toplam <= 1000)
            {
                toplam = toplam + dongu_say;
                dongu_say += 1;
            }
            MessageBox.Show("Döngü toplam " +dongu_say.ToString() + " kez çalıştı");
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int say = 1;
            do
            {
                listBox2.Items.Add(say);
                say++;
            } while (say <= 10);
        }
    }
}
