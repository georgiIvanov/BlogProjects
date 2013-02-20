using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Snake_Game
{
    class Food
    {
        private int width, height;
        private SolidBrush brush;
        public Rectangle foodRec;


        public Food(Random randFood)
        {
            brush = new SolidBrush(Color.Red);

            width = 10;
            height = 10;
            foodRec = new Rectangle(randFood.Next(0, 29) * 10, randFood.Next(0, 29) * 10, width, height);
        }

        public void FoodLocation(Random randFood, Snake s)
        {
            foodRec.X = randFood.Next(0, 29) * 10;
            foodRec.Y = randFood.Next(0, 29) * 10;
            for (int i = 0; i < s.SnakeRec.Length; i++)
            {
                if(this.foodRec.IntersectsWith(s.SnakeRec[i]))
                {
                    foodRec.X = randFood.Next(0, 29) * 10;
                    foodRec.Y = randFood.Next(0, 29) * 10;
                    i = 0;
                }
            }
        }

        public void drawFood(Graphics paper)
        {

            paper.FillRectangle(brush, foodRec);
        }
    }

    class BonusFood
    {
        private int x, y, width, height;
        private SolidBrush brush;
        public Rectangle foodRec;

        public bool DrawBonusFood { get; set; }
        public bool IsActive { get; set; }
        public int DurationInMSec { get; set; }
        public int Direction { get; set; }
        //if dtimer is < 0, direction can change
        public int DirectionTimer { get; set; }
        //public bool BonusFoodIsEaten { get; set; }
        

        public BonusFood()
        {
            brush = new SolidBrush(Color.Gold);

            width = 10;
            height = 10;
            DurationInMSec = 50;
            DrawBonusFood = false;
            IsActive = false;
            DirectionTimer = 0;
            //BonusFoodIsEaten = true;
            foodRec = new Rectangle(x, y, width, height);
        }

        public void BonusFoodLocationDirection(Random randFood)
        {
            x = randFood.Next(0, 29) * 5;
            y = randFood.Next(0, 29) * 10;

            Direction = randFood.Next(1, 5);

            this.DurationInMSec = randFood.Next(20, 80);
        }

        public void MoveBonusFood()
        {
            switch (Direction)
            {
                case 1: x += 8; break;
                case 2: x -= 8; break;
                case 3: y += 8; break;
                case 4: y -= 8; break;
            }
            if (DirectionTimer > 0)
                DirectionTimer--;
        }

        public void BonusDrawFood(Graphics paper)
        {
            foodRec.X = x;
            foodRec.Y = y;

            paper.FillRectangle(brush, foodRec);
        }

        public void SetX(int X)
        {
            x = X;
        }

        public void SetY(int Y)
        {
            y = Y;
        }



       

    }
}
