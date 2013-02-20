using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;


namespace Snake_Game
{
    public class Snake
    {
        private Rectangle[] snakeRec;
        private SolidBrush brush;
        private int x, y, width, height;

        public Snake()
        {
            snakeRec = new Rectangle[3];
            brush = new SolidBrush(Color.Blue);
            x = 150;
            y = 130;
            width = 10;
            height = 10;

            for (int i = 0; i < snakeRec.Length; i++)
            {
                snakeRec[i] = new Rectangle(x, y, width, height);
                x -= 10;
            }
        }

        public void drawSnake(Graphics paper)
        {
            foreach (Rectangle rec in snakeRec)
            {
                paper.FillRectangle(brush, rec);
            }
        }

        public void moveSnake()
        {
            for (int i = snakeRec.Length - 1; i > 0; i--)
            {
                snakeRec[i] = snakeRec[i - 1];
            }
        }

        public void moveDown()
        {
            moveSnake();
            snakeRec[0].Y += 10;
        }
        public void moveUp()
        {
            moveSnake();
            snakeRec[0].Y -= 10;
        }
        public void moveRight()
        {
            moveSnake();
            snakeRec[0].X += 10;
        }
        public void moveLeft()
        {
            moveSnake();
            snakeRec[0].X -= 10;
        }

        public Rectangle[] SnakeRec
        {
            get { return snakeRec; }
            set { this.snakeRec = value; }

        }

        public void growSnake()
        {
            List<Rectangle> rec = snakeRec.ToList();
            rec.Add(new Rectangle(snakeRec[snakeRec.Length-1].X,
                snakeRec[snakeRec.Length-1].Y, width, height));
            snakeRec = rec.ToArray();

        }

    }

    class testClass
    {

    }

    class SecondTestClass
    {
        string NOHISTOYFORU;
    }

    class BestClassEVER
    {
    }

}
