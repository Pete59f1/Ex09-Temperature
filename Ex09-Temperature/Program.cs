using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09_Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            int counter = 0;
            Temperature tempe = new Temperature();

            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\Peter\Documents\Visual Studio 2017\Projects\Ex09-Temperature\Ex09-Temperature\InputFil.txt");
            while((line = file.ReadLine()) != null)
            {
                string[] split = line.Split(' ');
                counter++;
                if(counter == 1)
                {
                    for(int i = 0; i < split.Length; i++)
                    {
                        tempe.Celsius = double.Parse(split[i]);
                        Console.WriteLine(tempe.Celsius);
                    }
                }
                Console.WriteLine("");
                
                if(counter == 2)
                {
                    for (int i = 0; i < split.Length; i++)
                    {
                        tempe.Fahrenheit = double.Parse(split[i]);
                        Console.WriteLine(tempe.Fahrenheit);
                    }
                }
            }
        }
    }
}
