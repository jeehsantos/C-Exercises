using System;

namespace Exercise09
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mat = Console.ReadLine().Split(' ');
            int search = 0;
            int line = int.Parse(mat[0]);
            int column = int.Parse(mat[1]);

            int[,] matSize = new int[line, column];
            for(int i = 0;i < line; i++)
            {
                string[] columnRead = Console.ReadLine().Split(' ');
                for(int j = 0; j < column; j++)
                {
                    matSize[i, j] = int.Parse(columnRead[j]);
                }
            }

            search = int.Parse(Console.ReadLine());
            for(int i = 0;i < line; i++)
            {
                for(int j = 0; j < column; j++)
                {
                    if(matSize[i,j] == search)
                    {
                        Console.WriteLine("Position:  {0}, {1}", i, j);
                        if(j > 0) {  
                        Console.WriteLine("Left: "+ matSize[i, j-1]);
                        }
                        if(i > 0)
                        {
                        Console.WriteLine("Up: " + matSize[i-1, j]);
                        }
                        if (j < column - 1){ 
                        Console.WriteLine("Right: "+ matSize[i, j+1]);
                        }
                        if(i < line - 1)
                        Console.WriteLine("Down: "+ matSize[i+1, j]);
                    }
                }
            }
        }
    }
}
