using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus' Room Dertail Generator!");
            bool run;
            string userinput;

                                   
            while (true)
            {
                double width, length, area, perimeter, volume, height;
                Console.WriteLine("User, type in the length of the room in feet: ");
                length = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("User, type in the width of the room in feet: ");
                width = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("User, type in the height of the room in feet: ");
                height = Convert.ToDouble(Console.ReadLine());

                area = width * length;
                Console.WriteLine("The area of the room is " + area +" feet");
                perimeter = (2 * width) + (2 * length);
                Console.WriteLine("The perimeter of the room is " + perimeter +" feet");
                volume = length * width * height;
                Console.WriteLine("The volume of the room is " + volume +" feet");
                                             
                                
                Console.WriteLine("Would you like to know the area, perimeters, and volume of another room? (enter Y/N): ");
                userinput = Console.ReadLine().ToLower();


                
                if (userinput.Equals("y"))
                {
                    run = true;
                }
                else
                {
                    Console.WriteLine("Alright, have a good day");
                    break;
                }
            }
        
    
        }
    }
}
