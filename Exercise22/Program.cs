using System;
using System.Collections.Generic;
using System.IO;
namespace Exercise22
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> file = new Dictionary<string, int>();
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        if (file.ContainsKey(line[0])){
                            file[line[0]] += int.Parse(line[1]);
                        }
                        else
                        {
                            file.Add(line[0], int.Parse(line[1]));

                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Message: " + e.Message);
            }
            finally
            {
                foreach(var f in file)
                {
                    Console.WriteLine(f.Key +" : " + f.Value);
                }
            }
        }
    }
}
