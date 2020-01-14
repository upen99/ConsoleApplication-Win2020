using System;

namespace ConsoleApp_NEW
{
    class Program
    {
        static void Main(string[] args)
        {
            // No2
            string myName = "Upen Rijal";
            string location = "Rexburg, ID";

            // No3
            Console.WriteLine($"My name is {myName}");
            Console.WriteLine($"I am from {location}");

            // No4
            var curDate = DateTime.Now; 
            Console.WriteLine($"Today is {curDate.ToString("ddd, dd MMM yyy")};");

            // No5
            var christmasDay = new DateTime(curDate.Year, 12, 25);
            var dayTilChristmas = curDate - christmasDay;
            Console.WriteLine($"Days untill Christmass is {dayTilChristmas.ToString("dd")}");

            //// No6
            double width, height, woodLength, glassArea; string widthString, heightString;
            Console.WriteLine("Please enter the width ");
            widthString = Console.ReadLine(); width = double.Parse(widthString);
            Console.WriteLine("Please enter the hight ");
            heightString = Console.ReadLine(); height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " + woodLength + " feet"); Console.WriteLine("The area of the glass is " + glassArea + " square metres");


            //.7
            Console.WriteLine("Press any key to quit");
            Console.ReadKey();

        }
    }
}
