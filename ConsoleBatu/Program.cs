using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBatu
{
    class Program
    {
        static void PrintArray(string[,] arr)
        {
            int rows = arr.GetLength(0);
            int col = arr.GetLength(1);
            StringBuilder sb = new StringBuilder();
            //print
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                sb.Append("[");
                for (int j = 0; j < arr.GetLength(1); j++)
                {

                    sb.Append(arr[i, j]);
                    if (j < (col - 1))
                    {
                        sb.Append(", ");
                    }
                }
                sb.Append("]");
                Console.WriteLine(sb.ToString());
                sb = new StringBuilder();
            }
        }
        static void Main(string[] args)
        {
            int[,] stone = new int[,]
           {
                {1,1,2,1,1},
                {2,3,2,2,2},
                {4,5,5,5,5},
                {6,6,6,7,6},
                {8,8,8,8,9},
           };

            string[,] result = new string[5, 2];

            for (int i = 0; i < stone.GetLength(0); i++)
            {
                int[] temp = new int[stone.GetLength(1)];
                for (int j = 0; j < stone.GetLength(1); j++)
                {
                    temp[j] = stone[i, j];
                }
                int[] sorted_temp = (from element in temp orderby element ascending select element).ToArray();
                int start = sorted_temp[0];
                int last = sorted_temp[(temp.Length) - 1];

                var _cntr = sorted_temp.Where(x => x == start).Count();
                if (_cntr == 1)
                {
                       result[i, 0] = Array.FindIndex(temp, item => item == start).ToString();
                       result[i, 1] = start.ToString();
                }
                else
                {
                    var _cntr_Last= sorted_temp.Where(x => x == last).Count();
                    if (_cntr_Last == 1)
                    {
                        result[i, 0] = Array.FindIndex(temp, item => item == last).ToString();
                        result[i, 1] = last.ToString();
                    }
                }
               
            }

            PrintArray(result);
        }
    }
}
