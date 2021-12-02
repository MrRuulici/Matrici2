using System;

namespace Matrici2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nr de linii=  ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nr de coloane=  ");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[n,m];
            int sumr = 0;
            int sumc = 0;

            Console.Write("Elementele matricii :\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"[{i}],[{j}] : ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("Randul ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Coloana ");
            int r = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(matrix[i, j] + " ");
                Console.Write("\n");
            }

           
            for (int i  = 0; i < n; i++)
            {
                sumc = sumc + matrix[i, r];
            }
            for (int j = 0; j < m; j++)
            {
                sumr = sumr + matrix[c, j];
            }
            Console.WriteLine($"Suma randului {c} este " + sumr);
            Console.WriteLine($"Suma coloanei {r} este " + sumc);
        }
    }

}

