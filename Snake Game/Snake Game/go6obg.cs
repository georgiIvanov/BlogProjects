using Snake_Game;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

class go6obg
{
    private int width, height;
    private SolidBrush brush;
    public Rectangle foodRec;


    public go6obg(Random randFood)
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
            if (this.foodRec.IntersectsWith(s.SnakeRec[i]))
            {
                foodRec.X = randFood.Next(0, 29) * 10;
                foodRec.Y = randFood.Next(0, 29) * 10;
                i = 0;
            }
        }
    }
}

