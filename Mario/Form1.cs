using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
                mario.Top -= 10;
            else if (e.KeyCode == Keys.Down)
                mario.Top += 10;

            if (mario.Top < 0)
                mario.Top = 0;

            if (mario.Bottom > 400)
                mario.Top = 400 - mario.Height;
        }

        Random r = new Random();
        int score = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            monster1.Left -= 5;

            int deltaX = r.Next(200);
            int deltaY = r.Next(350);
            
            if (monster1.Left < 0)
            {
                monster1.Left = 600 + deltaX;
                monster1.Top = deltaY;
                score++;
                timer1.Interval -= 2;
            }

            bool collision = false;

            if (monster1.Left < mario.Right)
            {
                if (monster1.Top >= mario.Top && monster1.Top <=  mario.Bottom)
                {
                    collision = true;
                }

                if (monster1.Bottom >= mario.Top && monster1.Bottom <= mario.Bottom)
                {
                    collision = true;
                }
            }

            if (collision)
            {
                timer1.Enabled = false;
                MessageBox.Show("Booo! You lost with score of " + score.ToString() + ".");
            }

        }
    }
}
