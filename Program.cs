using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;



namespace Room_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            bool exit = false;

            do
            {
                //Greeting the user to the console application
                Console.WriteLine("Hello! Welcome to the Grand Circus Room Calculator.");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("                                                  ");

                //Takes user input for length
                Console.Write("Please Enter the Length of the room:");
                string roomLength = Console.ReadLine();

                //Takes user input for width
                Console.Write("Please Enter the Width of the room:");
                string roomWidth = Console.ReadLine();

                //Takes user input for height
                Console.Write("Please Enter the Height of the room:");
                string roomHeight = Console.ReadLine();

                //Converts the inut strings to doubles allowing the program to use math on the inputs
                double length = double.Parse(roomLength);
                double width = double.Parse(roomWidth);
                double height = double.Parse(roomHeight);

                //Math calculations for area and peramiter of a room
                double area = length * width;
                double perimeter = (length + width) * 2;
                double volume = length * width * height;


                //Outputs initial calulations
                Console.WriteLine("    "); //deadspace
                Console.WriteLine("    ");
                Console.WriteLine("    ");
                Console.WriteLine("    ");
                Console.WriteLine("    ");
                Console.WriteLine("    "); //To make the output easier to read

                Console.WriteLine($"The area of the room entered is {area}.");
                Console.WriteLine("    ");
                Console.WriteLine($"The Perimeter of the room entered is {perimeter}.");
                Console.WriteLine("     ");
                Console.WriteLine($"The Volume of the room entered is {volume}.");

                //Outputs a small room
                if (area <= 250)
                {
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine($"This is a small room! The Area is: {area}");
                }

                //Outputs a Medium Room
                if (area > 250 && area < 650)
                {
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine($"This is a Medium room! The Area is: {area}");
                }

                //Outputs a large room
                if (area > 650)
                {
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine($"This is a Large room! The Area is: {area}");
                }

                Console.Write("Please enter 'y' if you would like to calculate another room:");
                string result = Console.ReadLine();

                if (result != "y")
                {
                    exit = true;
                }


            } while (exit == false);



        }

    }
}
