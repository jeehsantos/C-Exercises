using System;

namespace Exercise08
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int negatives = 0;
            int[,] mat = new int[x,x];

            for(int n = 0; n < x; n++) {
                string[] newNumber = Console.ReadLine().Split(' ');
                for (int i = 0; i < x; i++)
                {
                    if (int.Parse(newNumber[i]) < 0)
                    {
                        negatives++;
                    }
                    mat[n, i] = int.Parse(newNumber[i]);
                }
            }

            Console.WriteLine("Main diagonal");
            for (int n = 0; n < x; n++)
            {
                    Console.WriteLine(mat[n,n]);
                
            }
            Console.Write("Negative numbers: "+ negatives);
        }
    }
}
