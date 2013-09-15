using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateMatrix
{
    class RotateMatrix
    {
        static void Main(string[] args)
        {

            
            string matrixN = Console.ReadLine();
            int N = int.Parse(matrixN);

            int[,] matrix=new int[N,N];

            for (int i = 0; i < N; i++)
            {
                string value = Console.ReadLine();
                string[] values=value.Split(',');
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = int.Parse(values[j]);
                }

            }
            int temp = 0;
            int currentX=0;
            int currentY=0;
            int nextX=0;
            int nextY=0;
            for (int i = 0; i < (int)((N + 1) / 2); i++)
            {

                for (int j = i; j < N-i-1; j++)
                {

                    nextX = j;
                    nextY = N - 1 - i;
                    int current = matrix[i, j];

                    while (nextX != i || nextY != j)
                    {
                        temp = matrix[nextX, nextY];
                        matrix[nextX, nextY] = current;
                        current = temp;
                        currentX = nextX;
                        currentY = nextY;
                        nextX = currentY;
                        nextY = N - 1 - currentX;
                    }
                    matrix[nextX, nextY] = current;
                }
            }

            Console.WriteLine("########################");
            for (int i = 0; i < N; i++)
            {

                for (int j = 0; j < N; j++)
                {
                    Console.Write("{0},", matrix[i, j] );
                }
                Console.Write("\n");
            }            
        }
    }
}
