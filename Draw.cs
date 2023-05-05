using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirynt2._0
{
    internal class Draw
    {
        public static void DrawMap(char[,] map, int height, int width)
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    map[i, j].DrawObject();
                }
                Console.WriteLine("");
            }
        }
    }
}
