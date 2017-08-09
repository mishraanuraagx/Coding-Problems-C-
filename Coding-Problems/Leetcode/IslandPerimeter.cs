using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Problems.Leetcode
{
    class IslandPerimeter
    {
        public static void run()
        {
            int[,] grid = { { 0, 1, 0, 0 }, { 1, 1, 1, 0 }, { 0, 1, 0, 0 }, { 1, 1, 0, 0 } };
            int i = IslandPerimeterRunner(grid);
            Console.WriteLine(i);
        }
        public static int IslandPerimeterRunner(int[,] grid)
        {
            int totalPerimeter = 0;
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {

                    // TODO max: can check only in 2 directions, i.e. rgiht and bottom, cuz we already traversing left to right and sequentionally top to bottom but will still run at O(n)

                    int perimeterOfOneCell = 0;
                    if (grid[i, j] == 1)
                    {

                        /*check top*/
                        if (i > 0)
                        {
                            if (grid[i - 1, j] == 0)
                            {
                                perimeterOfOneCell++;
                            }
                        }
                        if (i == 0)
                        {
                            perimeterOfOneCell++;
                        }


                        /*check bottom*/
                        if (i < grid.GetLength(0) - 1)
                        {
                            if (grid[i + 1, j] == 0)
                            {
                                perimeterOfOneCell++;
                            }
                        }
                        if(i== grid.GetLength(0) - 1)
                        {
                            perimeterOfOneCell++;
                        }

                        /*check left*/
                        if (j > 0)
                        {
                            if (grid[i, j - 1] == 0)
                            {
                                perimeterOfOneCell++;
                            }
                        }
                        if (j == 0)
                        {
                            perimeterOfOneCell++;
                        }

                        /*check right*/
                        if (j < grid.GetLength(1)-1)
                        {
                            if (grid[i, j + 1] == 0)
                            {
                                perimeterOfOneCell++;
                            }
                        }
                        if(j== grid.GetLength(1) - 1)
                        {
                            perimeterOfOneCell++;
                        }

                    }

                    totalPerimeter += perimeterOfOneCell;
                }
            }
            return totalPerimeter;
        }
    }
}
