using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Birds_Windows_Form
{
    public partial class Form1 : Form
    {

        int pipeSpeed = 8;
        int gravity = 10;
        int score = 0;  

        public Form1()
        {
            InitializeComponent();
        }
        private void ground_Click(object sender, EventArgs e)
        {

        }
        private void pipeTop_Click(object sender, EventArgs e)
        {

        }

        private void flappyBird_Click(object sender, EventArgs e)
        {

        }

        

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreText.Text = score.ToString();

            if (pipeBottom.Left < -120)
            {
                pipeBottom.Left = 500;
                score++;
            }
            if (pipeTop.Left < -150)
            {
                pipeTop.Left = 750;
                score++;
            }

            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds) || flappyBird.Top < -20                  
                
                )
            {
                endGame();
            }
            if (score > 5)
            {
                pipeSpeed = 11;
             
            }
            if (score > 5)
            {
                pipeSpeed = 15;

            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Space)
            {
                gravity = -8;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Space)
            {
                gravity = 8;
            }
        }

        private void scoreText_Click(object sender, EventArgs e)
        {

        }
        private void endGame()
        {
            gameTimer.Stop();
            gameOver.Text += " GAME OVER";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
