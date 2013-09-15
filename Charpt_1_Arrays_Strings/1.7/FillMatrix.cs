using System;
//write an algorithm such that if an element in an MxN matrix is 0, its entire row and column are set to 0;

namespace FillMatrix
{
    class FillMatrix
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[,]{{1,2,3,4,9},{5,6,7,8,0},{9,9,11,12,9},{13,14,9,16,1}};

            FillMatrixZero(matrix);
        }

        static void FillMatrixZero(int[,] matrix)
        {
            int rowflag = 0;
            int columnflag = 0;
            PrintMatrix(matrix);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int currentRowFlag = 1 << i;
                    int currentColumnFlag = 1 << j;
                    if (matrix[i, j] == 0 && ((rowflag & currentRowFlag) == 0) && ((columnflag & currentColumnFlag) == 0))
                    {

                        rowflag |= currentRowFlag;
                        ClearRow(i, matrix);

                        columnflag |= currentColumnFlag;
                        ClearColumn(j, matrix);
                        break;
                    }

                }
            }

            PrintMatrix(matrix);
            Console.Read();
        }

        static void ClearRow(int row, int[,] matrix)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[row, j] = 0;

            }
        }
        static void ClearColumn(int Column, int[,] matrix)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                matrix[j, Column] = 0;

            }
        }

        static void PrintMatrix(int[,] matrix)
        {
            Console.Write("############################\n");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0},", matrix[i, j]);
                }
                Console.Write("\n");

            }
            Console.Write("############################\n");
        }
    }
}
