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
char[,] canvas = new char[size, size];

// 1. 초기화 (공백으로 채우기)
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        canvas[i, j] = ' ';
    }
}

// 중심 좌표
int cx = size / 2;
int cy = size / 2;

// 2. C 그리기 (세 변: 위, 아래, 왼쪽)
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        double dist = Math.Sqrt(SqrDistance2D(i, j, cx, cy));
        if (IsClose(dist, radius, 1.0))
        {
            // 세 변만 남기기
            if (j < cx - radius / 2 || i == cy - radius || i == cy + radius)
            {
                canvas[i, j] = '*';
            }
        }
    }
}

// 3. # 그리기 (정사각형 3등분 지점에 선분 추가)
int oneThird = size / 3;
int twoThirds = 2 * size / 3;

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        if (i == oneThird || i == twoThirds || j == oneThird || j == twoThirds)
        {
            canvas[i, j] = '*';
        }
    }
}

// 4. 출력
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        Console.Write(canvas[i, j]);
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