using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnslMobil
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
            string[,] mobil = new string[,]
            {
                 { "Ford", "Fiesta", "Manual", "Rp 120.000.000"},
                 { "Ford", "Fiesta", "Manual", "Rp 134.000.000"},
                 { "Ford", "Fiesta", "Automatic", "Rp 140.000.000"},
                 { "Ford", "Fiesta", "Automatic", "Rp 150.000.000"},
                 { "Ford", "Focus", "Manual", "Rp 330.000.000"},
                 { "Ford", "Focus", "Manual", "Rp 335.000.000"},
                 { "Ford", "Focus", "Manual", "Rp 350.000.000"},
                 { "Ford", "Focus", "Automatic", "Rp 360.000.000"},
                 { "VW", "Golf", "Manual", "Rp 350.000.000"},
                 { "VW", "Golf", "Automatic", "Rp 370.000.000"},

            };

            int rows = mobil.GetLength(0);
            int cols = mobil.GetLength(1);
            string[,] result = new string[rows, cols];

            for (int baris = 0; baris < mobil.GetLength(0); baris++)
            {
       
                for (int col = 0; col < mobil.GetLength(1); col++)
                {
                    if (baris == 0)
                    {
                        result[baris, col] = mobil[baris, col];
                    }
                    else
                    {
                        if (mobil[baris, col] == mobil[(baris - 1), col])
                        {
                            result[baris, col] = "";
                        }
                        else
                        {
                            result[baris, col] = mobil[baris, col];
                        }
                    }
                }
            }

            PrintArray(result);


        }
    }
}
