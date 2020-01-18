using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            string name;
            Console.WriteLine("What is your name? (first&last): ");
            name = Console.ReadLine();

            string location;
            Console.WriteLine("Where are you currently located?: ");
            location = Console.ReadLine();

            Console.WriteLine("Your name is " + name);
            Console.WriteLine("You am currently living in " + location);

            
            var currentDate = DateTime.Now;
            Console.WriteLine("Todays date is " + currentDate.ToString("MM/dd/yyyy"));

            Console.WriteLine("Press any key to see how many days till Christmas");
            Console.ReadKey();
            var christmasDate = new DateTime(currentDate.Year,12,25);
            TimeSpan tillChristmas = christmasDate.Subtract(currentDate);
            Console.WriteLine("There are " + tillChristmas.Days + " many days till Christmas!");

            Console.WriteLine("Press any key to begin measurements");
            Console.ReadKey();
            double width, height, woodLength, glassArea;
                string widthString, heightString;
                Console.WriteLine("What is the Width?");
                widthString = Console.ReadLine();
                width = double.Parse(widthString);
                Console.WriteLine("What is the Height?");
                heightString = Console.ReadLine();
                height = double.Parse(heightString);
                woodLength = 2 * (width + height) * 3.25;
                glassArea = 2 * (width * height);

                Console.WriteLine("The length of the wood is " +
                woodLength + " feet");

                Console.WriteLine("The area of the glass is " +
                glassArea + " square metres");

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}