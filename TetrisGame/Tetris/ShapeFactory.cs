using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Tetris.ShapesStore;

namespace Tetris
{
    static class ShapeFactory
    {
        static private Random random = new Random();

        static public Shape CreateRandomShape(int posRow, int posCol, int blockSize)
        {
            switch (random.Next(1,8))
            { 
                case 1:
                    return new ShapeT(posRow, posCol, blockSize);
                case 2:
                    return new ShapeO(posRow, posCol, blockSize);
                case 3:
                    return new ShapeJ(posRow, posCol, blockSize);
                case 4:
                    return new ShapeL(posRow, posCol, blockSize);
                case 5:
                    return new ShapeI(posRow, posCol, blockSize);
                case 6:
                    return new ShapeS(posRow, posCol, blockSize);
                default:
                    return new ShapeZ(posRow, posCol, blockSize);
            }
        }
    }
}