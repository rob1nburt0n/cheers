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
            System.Console.WriteLine("What's your birthday? (MM/DD)");
            string bday = System.Console.ReadLine();
            DateTime convertedBday = Convert.ToDateTime(bday);
            DateTime today = DateTime.Today;

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
            if (convertedBday.Equals(today))
            {
                Console.WriteLine("Happy Birthday!!");
            }
            else
            {
                if (convertedBday < today)
                {
                    convertedBday = convertedBday.AddYears(1);
                }
                Console.WriteLine("Your birthday is " + convertedBday.Subtract(today).Days + " days away! Happy Birthday in Advance!");
            }
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
        }
    }
}
