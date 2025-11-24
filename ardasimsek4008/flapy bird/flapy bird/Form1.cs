using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace flapy_bird
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int pipeSpeed = 8;   // Boruların hızı
            int gravity = 5;     // Kuşun düşüş hızı
            int score = 0;       // Skor

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            private void gameTimer_Tick(object sender, EventArgs e)
        {
            // Kuşun düşmesini sağla
            flappyBird.Top += gravity;

            // Boruları sola hareket ettir
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;

            // Skor yazısını güncelle
            scoreText.Text = "Score: " + score;

            // Borular ekran dışına çıkınca tekrar sağa al
            if (pipeBottom.Left < -150)
            {
                pipeBottom.Left = 800;  // Ekranın sağından tekrar başlat
                score++;               // Skoru artır
            }

            if (pipeTop.Left < -180)
            {
                pipeTop.Left = 950;    // Ekranın sağından tekrar başlat
                score++;               // Skoru artır
            }

            // Çarpışma kontrolü
            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds) ||
                flappyBird.Top < -25)  // Kuş çok yukarı çıkarsa
            {
                endGame();
            }

            // İstersen zorlaşma efekti için boru hızını artırabilirsin
            if (score > 5) pipeSpeed = 10;
            if (score > 10) pipeSpeed = 12;
        }

    }
}
}
