using System;

namespace Lab_10___CircleTime_
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            bool go = true;
            while (go)
            {
                Console.WriteLine("Welcome to the Circle Tester would you like to find the area and circumference please enter a radius.");

                try
                {
                    int input = int.Parse(Console.ReadLine());
                    Circle circle = new Circle(input);
                   
                    Console.WriteLine($"AREA: {circle.CalculateFormatedArea()}");
                    Console.WriteLine($"CIRCUMFERENCE: {circle.CalculateFormatedCircumference()}\n");
                    counter++;
                    go = Continue(counter);
                    
                }
                catch
                {
                    Console.WriteLine($"This is invalid please try again.\n");
                    go = Continue(counter);
                }
            }
        }
        public static bool Continue(int counter)
        {
            Console.WriteLine($"Press {'y'} to continue or any other key to exit. . .\n");

            char response = Console.ReadKey(true).KeyChar;

            if (response == 'y')
            {
                Console.Clear();
                return true;
            }
            else if (response != 'y')
            {
                Console.WriteLine($"GoodBye! You made {counter} Circles objects");
                return false;
            }
            else
            {
                return Continue(counter);
            }
        }
    }
}
