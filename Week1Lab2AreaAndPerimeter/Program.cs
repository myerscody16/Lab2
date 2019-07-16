using System;

namespace Week1Lab2AreaAndPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            char repeatDec;
            bool repeat = true;
            while (repeat == true)
            {
                //input - ask for L, W, H
                Console.WriteLine("This will calculate the perimeter, area, and volume of a given rectangular room");

                Console.WriteLine("Input the length of the room and press enter. (in feet, please use decimal form)");
                string length = Console.ReadLine();
                Double Length = Double.Parse(length);

                Console.WriteLine("Input the width of the room and press enter. (in feet, please use decimal form)");
                string width = Console.ReadLine();
                Double Width = Double.Parse(width);

                Console.WriteLine("Input the height of the room and press enter. (in feet, please use decimal form)");
                string height = Console.ReadLine();
                Double Height = Double.Parse(height);

                //Process - find Perimeter and Area

                Double Area = Length * Width;
                Double Perimeter = (2 * Length) + (2 * Width);
                Double Volume = Length * Width * Height;

                //Output the values

                Console.WriteLine("The area of the room is {0} ft", Area);
                Console.WriteLine("The perimeter of the room is {0} ft^2", Perimeter);
                Console.WriteLine("The volume of the room is {0} ft^3", Volume);

                //Ask them if they want to run program again
                
                Console.WriteLine("Do you want to run this program again? (y/n)");
                repeatDec = Convert.ToChar(Console.ReadLine().ToLower());
                if (repeatDec != 'y')
                {
                    repeat = false;
                }

            }

        }
    }
}
