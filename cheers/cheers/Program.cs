using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cheers
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello there! What's your name?");
            string name = System.Console.ReadLine();
            System.Console.WriteLine("Hi, " + name);

            foreach (char letter in name.ToLower())
            {
               string article = "a";
                 foreach (char vowelSound in "halfnorsemix")
                 {
                 if (letter == vowelSound)
                       {
                          article = "an";
                        }
                        }
               Console.WriteLine("Give me " + article + " " + letter);
                          }
               
                Console.WriteLine(name.ToUpper() + " is GRAND");
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
        }
    }
}
