using System;

namespace LAB6
{
    class Program
    {
        static void Main()
        {
            // Завдання 1
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
                Console.WriteLine("The number is even.");
            else
                Console.WriteLine("The number is odd.");

            //Завдання 2
            Console.Write("Enter your grade (0-100): ");
            int score = int.Parse(Console.ReadLine());
            if (score >= 90)
                Console.WriteLine("Your grade: A");
            else if (score >= 75)
                Console.WriteLine("Your grade: B");
            else if (score >= 60)
                Console.WriteLine("Your grade: C");
            else
                Console.WriteLine("Your grade: F");

            //Завдання 3
            Console.Write("Enter a number (1-7): ");
            int day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 1: Console.WriteLine("Monday"); break;
                case 2: Console.WriteLine("Tuesday"); break;
                case 3: Console.WriteLine("Wednesday"); break;
                case 4: Console.WriteLine("Thursday"); break;
                case 5: Console.WriteLine("Friday"); break;
                case 6: Console.WriteLine("Saturday"); break;
                case 7: Console.WriteLine("Sunday"); break;
                default: Console.WriteLine("Unknown day"); break;
            }

            //Завдання 4
            Console.Write("Enter a car brand: ");
            string car = Console.ReadLine();
            switch (car)
            {
                case "Toyota": Console.WriteLine("Japan"); break;
                case "BMW": Console.WriteLine("Germany"); break;
                case "Tesla": Console.WriteLine("USA"); break;
                default: Console.WriteLine("Unknown brand"); break;
            }

            //Завдання 5
            Console.Write("Enter the temperature: ");
            int temp = int.Parse(Console.ReadLine());
            Console.WriteLine(temp >= 0 ? "The weather is warm" : "The weather is cold");

            //Завдання 6
            try
            {
                Console.Write("Enter the first number: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("Enter the second number: ");
                int b = int.Parse(Console.ReadLine());
                int result = a / b;
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero!");
            }
        }
    }
}