using System;

namespace LAB5
{
    class Program
    {
        // Завдання 1: Перевірка парності числа
        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        // Завдання 2: Перевантаження функції Sum
        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        static double Sum(double a, double b)
        {
            return a + b;
        }

        // Завдання 3: Обмін значеннями з використанням ref
        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("1: Перевірка парності");
            Console.WriteLine($"IsEven(8): {IsEven(8)}");   // true
            Console.WriteLine($"IsEven(7): {IsEven(7)}");   // false
            Console.WriteLine();

            Console.WriteLine("Завдання 2: Перевантаження Sum");
            Console.WriteLine($"Sum(5, 10): {Sum(5, 10)}");           // 15
            Console.WriteLine($"Sum(2, 3, 4): {Sum(2, 3, 4)}");       // 9
            Console.WriteLine($"Sum(2.5, 3.1): {Sum(2.5, 3.1)}");     // 5.6
            Console.WriteLine();

            Console.WriteLine("Завдання 3: Обмін значень (ref) ");
            int a = 5, b = 10;
            Console.WriteLine($"До Swap: a = {a}, b = {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"Після Swap: a = {a}, b = {b}");      // a = 10, b = 5
        }
    }
}
