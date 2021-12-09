using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int gravity = 10;
        int pipespeed = 6;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            birb.Top += gravity;
            pipetop.Left = pipespeed;
            pipebottom.Left = pipespeed;
            scorelabel.Text = $"score: {score}";

            if(pipetop.Left < -100)
            {
                pipetop.Left = 500;
                score++;
            }

            if(pipebottom.Left < -100)
            {
                pipebottom.Left = 600;
                score++;
            }

            if(birb.Top < +25)
            {
                gameOver();
            }

            if(birb.Bounds.IntersectsWith(pipetop.Bounds) || birb.Bounds.IntersectsWith(pipebottom.Bounds) || birb.Bounds.IntersectsWith(ground.Bounds))
            {
                gameOver();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5;
            }
        }

        private void birb_Click(object sender, EventArgs e)
        {

        }

        private void gameOver()
        {
            timer1.Stop();
            scorelabel.Text = "Game Over";
            playAgain.Visible = true;
        }

        private void playAgain_Click(object sender, EventArgs e)
        {
            Form1 newform = new Form1();
            newform.Show();
            this.Dispose(false);
        }
    }
}
