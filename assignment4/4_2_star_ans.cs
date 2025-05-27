using System;

namespace star
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius: ");
            int radius = int.Parse(Console.ReadLine());
            int size = 2 * (radius + 1);

            // ---------- TODO ----------
            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x <= 24; x++)
                {
                    bool draw = false;

                    // 오른쪽 수직줄
                    if (x == 17 || x == 19)
                    {
                        draw = true;
                    }

                    // 왼쪽 수직줄 (세로줄)
                    if (x == 1 && y >= 2 && y <= 9)
                    {
                        draw = true;
                    }

                    // 왼쪽 수평줄
                    if ((y == 1 || y == 10) && x >= 2 && x <= 10)
                    {
                        draw = true;
                    }

                    // 중간 가로줄 (오른쪽)
                    if ((y == 4 || y == 8) && x >= 11 && x <= 24)
                    {
                        draw = true;
                    }

                    Console.Write(draw ? "*" : " ");
                }
                Console.WriteLine();
            }
            // --------------------
        }

        // calculate the distance between (x1, y1) and (x2, y2)
        static double SqrDistance2D(double x1, double y1, double x2, double y2)
        {
            return Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2);
        }

        // Checks if two values a and b are within a given distance.
        // |a - b| < distance
        static bool IsClose(double a, double b, double distance)
        {
            return Math.Abs(a - b) < distance;
        }
    }
}


/* example output
Enter the radius: 
>> 5
                *   *   
  *********     *   *   
 *              *   *   
 *              *   *   
 *          ************
 *              *   *   
 *              *   *   
 *              *   *   
 *          ************
 *              *   *   
 *              *   *   
  *********     *   *   

*/

/* example output (CHALLANGE)
Enter the radius: 
>> 5
                *   *  
      *         *   *  
   *     *      *   *  
  *                    
           ************
               *   *   
 *             *   *   
               *   *   
           ************
  *                    
   *     *    *   *    
      *       *   *    

*/