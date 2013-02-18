using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Snake_Game
{
    public partial class Form1 : Form
    {
        Random randFood = new Random();
        Graphics paper;
        Snake snake;
        Food food;
        BonusFood bonusFood;

        bool left = false;
        bool right = false;
        bool down = false;
        bool up = false;

        int score = 0;

        public Form1()
        {
            InitializeComponent();
            food = new Food(randFood);
            bonusFood = new BonusFood();

            start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Down && up == false)
            {
                down = true;
                up = false;
                right = false;
                left = false;
            }

            if (e.KeyData == Keys.Up && down == false)
            {
                down = false;
                up = true;
                right = false;
                left = false;
            }

            if (e.KeyData == Keys.Right && left == false)
            {
                down = false;
                up = false;
                right = true;
                left = false;
            }

            if (e.KeyData == Keys.Left && right == false)
            {
                down = false;
                up = false;
                right = false;
                left = true;
            }

            if (e.KeyData == Keys.Space)
            {
                timer1.Enabled = true;
                spaceBarlbl.Text = "";
                down = false;
                up = false;
                right = true;
                left = false;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            paper = e.Graphics;
           
            food.drawFood(paper);

            if (bonusFood.IsActive == true)
            {
                bonusFood.BonusDrawFood(paper);
            }

            snake.drawSnake(paper);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

            if (down) { snake.moveDown(); }
            else if (up) { snake.moveUp(); }
            else if (right) { snake.moveRight(); }
            else if (left) { snake.moveLeft(); }

            if (bonusFood.IsActive)
            {
                if (bonusFood.DurationInMSec > 0)
                    bonusFood.DurationInMSec--;
                else
                    bonusFood.IsActive = false;
            }

            //for (int i = 0; i < snake.SnakeRec.Length; i++)
            
            if(snake.SnakeRec[0].IntersectsWith(food.foodRec) && food.IsActive)
            {
                score += 10;
                snakeScorelbl.Text = Convert.ToString(score);
                snake.growSnake();
                //determines if bonus food will spawn
                if ((randFood.Next(1, 10) & 1) == 0)
                {
                    bonusFood.BonusFoodLocationDirection(randFood);

                    //checks if location is in snake and if it is, changes spawn location
                    foreach(Rectangle s in snake.SnakeRec)
                    {
                        if (bonusFood.foodRec.IntersectsWith(s)) 
                        {
                            bonusFood.BonusFoodLocationDirection(randFood);
                        }
                            
                    }
                    bonusFood.IsActive = true;
                }
                food.FoodLocation(randFood, snake);
            }
            else if (bonusFood.IsActive && snake.SnakeRec[0].IntersectsWith(bonusFood.foodRec))
            {
                score += bonusFood.DurationInMSec;
                snakeScorelbl.Text = Convert.ToString(score);
                bonusFood.IsActive = false;
            }

            if (bonusFood.IsActive)
            {
                bonusFood.MoveBonusFood();
            }
            collisionWithSelfAndWindow();

            this.Invalidate();
        }

        public void collisionWithSelfAndWindow()
        {
            for (int i = 1; i < snake.SnakeRec.Length; i++)
            {
                //collision with the snake itself
                if (snake.SnakeRec[0].IntersectsWith(snake.SnakeRec[i]))
                {
                    restart();
                }
                //306;350 - size
                //collision with window borders, snake passes on opposite side
                if (snake.SnakeRec[0].X <= -10)
                {
                    snake.SnakeRec[0].X = 290;
                } else

                if (snake.SnakeRec[0].X > 290)
                {
                    snake.SnakeRec[0].X = 0;
                }

                if (snake.SnakeRec[0].Y < 0)
                {
                    snake.SnakeRec[0].Y = 290;
                } else

                if (snake.SnakeRec[0].Y > 290)
                {
                    snake.SnakeRec[0].Y = 0;
                }

                //collision of the bonus food with window borders
                //bfood passes on the opposite side
                if (bonusFood.IsActive)
                {
                    if (bonusFood.foodRec.X<= -10)
                    {
                        bonusFood.SetX(290);
                    }
                    else if (bonusFood.foodRec.X > 290)
                        {
                            bonusFood.SetX(0);
                        }

                    if (bonusFood.foodRec.Y < 0)
                    {
                        bonusFood.SetY(290);
                    }
                    else if (bonusFood.foodRec.Y > 290)
                        {
                            bonusFood.SetY(0);
                        }

                    try
                    {
                        if (snake.SnakeRec[i].IntersectsWith(bonusFood.foodRec)
                            && bonusFood.DirectionTimer <= 0)
                        {

                            switch (bonusFood.Direction)
                            {
                                case 1: bonusFood.Direction = 2; break;
                                case 2: bonusFood.Direction = 1; break;
                                case 3: bonusFood.Direction = 4; break;
                                case 4: bonusFood.Direction = 3; break;
                            }

                            bonusFood.DirectionTimer = 4;
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        start();
                    }
                }

            }
        }

        public void restart()
        {
            timer1.Enabled = false;
            MessageBox.Show("Snake is dead. You scored: " + score);
            snakeScorelbl.Text = "0";
            score = 0;
            spaceBarlbl.Text = "Press space bar to begin!";
            snake = new Snake();
        }

        public void start()
        {
            timer1.Enabled = false;
            spaceBarlbl.Text = "Press space bar to begin!";
            snake = new Snake();
        }
    }
}
