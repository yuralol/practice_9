using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{

    class Program
    {
        static void Main(string[] args)
        {
            int ARRAYSIZE = 6;
            int[,] array = new int[ARRAYSIZE,ARRAYSIZE];
            var rnd = new Random();
            for(int i = 0; i < ARRAYSIZE; i++)
            {
                for(int j = 0; j < ARRAYSIZE; j++)
                {
                    array[i, j] = 50 - rnd.Next() % 100;
                    Console.Write(array[i, j]+" ");
                }
                Console.WriteLine();
            }

            int result = 1;
            for (int k = 0; k < ARRAYSIZE; k++)
            {
                result = 1;
                for (int i = 0; i <= k; i++)
                {
                    if (array[i, k - i] < 0 && (array[i, k - i] % 2 == 1 || array[i, k - i] % 2 == -1))
                    {
                        result *= array[i, k - i];
                    }
                }
                Console.Write(result + " |");
            }
            for (int k = 0; k < ARRAYSIZE+1; k++)
            {
                result = 1;
                for (int i = 1; i < k; i++)
                {
                    if (array[ARRAYSIZE - (k - i), ARRAYSIZE - i] < 0 && (array[ARRAYSIZE - (k - i), ARRAYSIZE - i] % 2 == 1 || array[ARRAYSIZE - (k - i), ARRAYSIZE - i] % 2 == -1))
                    {
                        result *= array[ARRAYSIZE - (k - i), ARRAYSIZE - i];
                    }
                }
                Console.Write(result + " |");
            }


            bool flag = false;
            int bobble = 0;
            do
            {
                flag = false;
                for (int i = 0; i < ARRAYSIZE; i++)
                {
                    for (int j = i; j < ARRAYSIZE; j++)
                    {
                        if (i == j) { continue; }
                        if (array[i, i] < array[j,j] && array[i, i] > 0 && array[i, i] % 2 == 0 && array[j,j] > 0 && array[j,j] % 2 == 0)
                        {
                            flag = true;
                            bobble = array[i, i];
                            array[i, i] = array[j,j];
                            array[j,j] = bobble;
                        }
                    }
                }
            } while (flag);
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < ARRAYSIZE; i++)
            {
                for (int j = 0; j < ARRAYSIZE; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
