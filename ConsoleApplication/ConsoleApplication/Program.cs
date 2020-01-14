using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Chelsea Blaszczyk";
            string location = "Miserably snowy rexburg";
            Console.WriteLine("My name is " + name + " and I am from " + location);

            var currentDate = DateTime.Now;
            Console.WriteLine(currentDate.ToString("MM/dd/yyyy"));

            var christmasDate = new DateTime(currentDate.Year,12,25);

            var tillChristmas = currentDate - christmasDate;
            
            //TimeSpan

            //convert to day

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}