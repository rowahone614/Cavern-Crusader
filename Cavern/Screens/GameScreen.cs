using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameSystemServices;
using System.Threading;
using System.Media;

namespace Cavern
{
    //Cavern Crusader
    //Made by Rowan Honeywell and Seamus Kittmer
    //January 22, 2020
    public partial class GameScreen : UserControl
    {
        //Variable Declaration

        Boolean downArrowDown, upArrowDown;
        int yPosition;
        int obstacleCounter = 0;
        int obstacleSpeed = 6;
        int crusaderSpeed;
        int obstacleStart;
        int randomY2;
        int oppositeRandomY;
        int scoreCounter = 0;
        double speedCounter = 1;

        //Random Declarations

        Random randObstacleSize = new Random();

        //Media Declarations

        SoundPlayer deathSound = new SoundPlayer(Properties.Resources.deathSound);
        SoundPlayer speedUpSound = new SoundPlayer(Properties.Resources.speedUpSound);
        SoundPlayer jetpackSound = new SoundPlayer(Properties.Resources.jetpackSound);
        public GameScreen()
        {
            InitializeComponent();
            InitializeGameValues();
        }

        public void InitializeGameValues()
        {
            yPosition = 200;
            crusaderSpeed = 10;
            MainForm.lastScore = scoreCounter;
            obstacleStart = 600;
            randomY2 = randObstacleSize.Next(20, 320);
            oppositeRandomY = this.Height - randomY2;
            Graphics g = this.CreateGraphics();

            //Initial Obstacle Drawing

            stalag1.Location = new Point(obstacleStart, randomY2 + 50);
            stalag1.Size = new Size(100, this.Height - randomY2);
            stalac2.Location = new Point(obstacleStart, 0);
            stalac2.Size = new Size(100, randomY2);
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && gameTimer.Enabled)
            {
                gameTimer.Enabled = false;
                upArrowDown = downArrowDown = false;

                DialogResult result = PauseForm.Show();

                if (result == DialogResult.Cancel)
                {
                    gameTimer.Enabled = true;
                }
                else if (result == DialogResult.Abort)
                {
                    MainForm.ChangeScreen(this, "MenuScreen");
                }
            }
            switch (e.KeyCode)
            {
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
            }
        }
        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
            }
        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {    
            if (downArrowDown == true && yPosition <= this.Height - 41)
            {
                yPosition = yPosition + crusaderSpeed;
                crusaderDesign(yPosition);
            }
            if (upArrowDown == true && yPosition >= 0)
            {
                yPosition = yPosition - crusaderSpeed;
                crusaderDesign(yPosition);
                jetpackSound.Play();
            }

            //Score Changes

            scoreCounter++;
            scoreLabel.Text = "Score = " + scoreCounter;

            obstacleMove();

            if (obstacleCounter == 5)
            {
                //Speed Changes

                obstacleSpeed = obstacleSpeed + 3;
                obstacleCounter = 0;
                speedLabel.Text = "Speed = " + speedCounter;
                speedUpSound.Play();
            }

            //Hitbox Declarations

            Rectangle heroRec = new Rectangle(crusaderImage.Location, crusaderImage.Size);
            Rectangle topObjectRec1 = new Rectangle(stalac2.Location.X + 20, stalac2.Location.Y, 30, randomY2 *3/4);
            Rectangle topObjectRec2 = new Rectangle(stalac2.Location.X + 40, stalac2.Location.Y, 30, randomY2 *4/5);
            Rectangle topObjectRec3 = new Rectangle(stalac2.Location.X + 50, stalac2.Location.Y, 30, randomY2 * 14/15);
            Rectangle bottomObjectRec1 = new Rectangle(stalag1.Location.X + 15, stalag1.Location.Y + oppositeRandomY* 1/3, 30, oppositeRandomY);
            Rectangle bottomObjectRec2 = new Rectangle(stalag1.Location.X + 25, stalag1.Location.Y + oppositeRandomY* 1/4, 30, oppositeRandomY);
            Rectangle bottomObjectRec3 = new Rectangle(stalag1.Location.X + 47, stalag1.Location.Y, 7, oppositeRandomY);

            if (heroRec.IntersectsWith(topObjectRec1) || heroRec.IntersectsWith(topObjectRec2) || heroRec.IntersectsWith(topObjectRec3)
                || heroRec.IntersectsWith(bottomObjectRec1) || heroRec.IntersectsWith(bottomObjectRec2) || heroRec.IntersectsWith(bottomObjectRec3))
            {
                gameTimer.Enabled = false;
                deathSound.Play();
                gameOverLabel.Text = "Game Over!";
                gameOverLabel.Refresh();
                MainForm.lastScore = scoreCounter;
                Thread.Sleep(2000);
                MainForm.ChangeScreen(this, "MenuScreen");
            }
            Refresh();
        }
        private void crusaderDesign(int crusaderY)
        {
            //Crusader Position Declaration

            crusaderImage.Location = new Point(100, crusaderY);
        }
        private void obstacleMove()
        {
            //Obstacle Position Changes

            obstacleStart = obstacleStart - obstacleSpeed;
            Graphics g = this.CreateGraphics();
            stalag1.Location = new Point(obstacleStart, stalag1.Location.Y);
            stalac2.Location = new Point(obstacleStart, stalac2.Location.Y);
    
            if (obstacleStart < -100)
            {
                //Obstacle Position and Size Reset 
                obstacleStart = 600;
                randomY2 = randObstacleSize.Next(20, 300);
                stalag1.Location = new Point(obstacleStart, randomY2 + 50);
                stalag1.Size = new Size(100, this.Height - randomY2);
                stalac2.Location = new Point(obstacleStart, 0);
                stalac2.Size = new Size(100, randomY2);
                obstacleCounter++;
                speedCounter = speedCounter + 0.2;
            }
        }
    }
}
