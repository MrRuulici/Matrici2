using System;

namespace Matrici2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nr de linii si coloane: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] arr1 = new int[n,m];
            int[] sumar = new int[n];
            int[] sumac= new int[n];

            Console.Write("Elementele matricii :\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"element - [{i}],[{j}] : ");
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(arr1[i, j] + " ");
                Console.Write("\n");
            }

           
            for (int i  = 0; i < n; i++)
            {
                sumar[i] = 0;
                for (int j = 0; j < m; j++)
                    sumar[i] = sumar[i] + arr1[i, j];
                Console.WriteLine($"Suma linia {i+1} = " + sumar[i]);
            }

            
            for (int i = 0; i < n; i++)
            {
                sumac[i] = 0;
                for (int j = 0; j < n; j++)
                    sumac[i] = sumac[i] + arr1[j, i];
                Console.WriteLine($"Suma coloana {i + 1} = " + sumac[i]);
            }
        }
    }

}

