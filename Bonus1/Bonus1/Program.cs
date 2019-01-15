using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus1
{
    class Program
    {
        static void Main(string[] args)
        {
                    
            Console.WriteLine("Welcome to the Letter Grade Converter!");

            string userinput;
            userinput = "y";

            double grade;

            while (userinput == "y")
            {
                Console.WriteLine("Enter a numerical grade (0-100): ");
                grade = Convert.ToDouble(Console.ReadLine());
                if (grade >= 99)
                {
                    Console.WriteLine("Letter Grade: A+");
                }
                else if (grade < 99 && grade >= 91)
                {
                    Console.WriteLine("Letter Grade: A");
                }
                else if (grade < 91 && grade >= 88)
                {
                    Console.WriteLine("Letter Grade: A-");
                }
                else if (grade < 88 && grade >= 86)
                {
                    Console.WriteLine("Letter Grade: B+");
                }
                else if (grade < 86 && grade >= 82)
                {
                    Console.WriteLine("Letter Grade: B");
                }
                else if (grade < 82 && grade >=80)
                {
                    Console.WriteLine("Letter Grade: B-");
                }
                else if (grade < 80 && grade >= 77)
                {
                    Console.WriteLine("Letter Grade: C+");
                }
                else if (grade < 77 && grade >= 70)
                {
                    Console.WriteLine("Letter Grade: C");
                }
                else if (grade < 70 && grade >= 67)
                {
                    Console.WriteLine("Letter Grade: C-");
                }
                else if (grade < 67 && grade >= 64)
                {
                    Console.WriteLine("Letter Grade: D+");
                }
                else if (grade < 64 && grade >= 63)
                {
                    Console.WriteLine("Letter Grade: D");
                }
                else if (grade < 63 && grade >= 60)
                {
                    Console.WriteLine("Letter Grade: D-");
                }
                //worksheet said D=66-60 and F=60-0. Changing F top grade to be 59
                else
                {
                    Console.WriteLine("Letter Grade: F");
                }



                Console.WriteLine("Continue? (y/n): ");
                userinput =  Console.ReadLine().ToLower();
            }
            Console.WriteLine("Goodbye");

            Console.ReadLine();
        }
    }
}
