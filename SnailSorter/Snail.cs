using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsApp
{
    class SnailSolution
    {

        private static void TopToRight(int[][] matrix, int[] arr, int loopCounter, int x, int y, int resultCurrentIndex)
        {
            for (int i = 0; i < x - loopCounter * 2; i++)
            {
                arr[resultCurrentIndex + i] = matrix[loopCounter][loopCounter + i];
            }
        }
        private static void RightToBottom(int[][] matrix, int[] arr, int loopCounter, int x, int y, int resultCurrentIndex)
        {
            for (int i = 0; i < y - 1 - loopCounter * 2; i++)
            {
                arr[resultCurrentIndex + i] = matrix[loopCounter + 1 + i][x - 1 - loopCounter];
            }
        }
        private static void BottomToLeft(int[][] matrix, int[] arr, int loopCounter, int x, int y, int resultCurrentIndex)
        {
            for (int i = 0; i < x - 1 - loopCounter * 2; i++)
            {
                arr[resultCurrentIndex + i] = matrix[y - 1 - loopCounter][x - 2 - i - loopCounter];
            }
        }
        private static void LeftToTop(int[][] matrix, int[] arr, int loopCounter, int x, int y, int resultCurrentIndex)
        {
            for (int i = 0; i < y - 2 - loopCounter * 2; i++)
            {
                arr[resultCurrentIndex + i] = matrix[y - 2 - loopCounter - i][loopCounter];
            }
        }
        public static int[] Snail(int[][] matrix)
        {
            if (matrix.Length == 0 || matrix[0].Length == 0)
            {
                return new int[] { 0 };
            } 

            int x = matrix[0].Length;
            int y = matrix.Length;
            int[] result = new int[y * x];
            int loopCounter = 0;
            int resultCurrentIndex = 0;
            
            while (true)
            {
                if (resultCurrentIndex < x * y)
                {
                    TopToRight(matrix, result, loopCounter, x, y, resultCurrentIndex);
                    resultCurrentIndex = resultCurrentIndex + x - loopCounter * 2;
                }
                else break;

                if (resultCurrentIndex < x * y)
                {
                    RightToBottom(matrix, result, loopCounter, x, y, resultCurrentIndex);
                    resultCurrentIndex = resultCurrentIndex + y - 1 - loopCounter * 2;
                }
                else break;

                if (resultCurrentIndex < x * y)
                {
                    BottomToLeft(matrix, result, loopCounter, x, y, resultCurrentIndex);
                    resultCurrentIndex = resultCurrentIndex + x - 1 - loopCounter * 2;
                }
                else break;

                if (resultCurrentIndex < x * y)
                {
                    LeftToTop(matrix, result, loopCounter, x, y, resultCurrentIndex);
                    resultCurrentIndex = resultCurrentIndex + y - 2 - loopCounter * 2;
                }
                else break;

                loopCounter++;
            }
            return result;
        }
    }
}
