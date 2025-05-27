using System;

namespace LAB7
{
    class Program
    {
        static void Main()
        {
            // Завдання 1
            Console.WriteLine("Парні числа від 2 до 20:");
            for (int i = 2; i <= 20; i += 2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");

            // Завдання 2
            int sum = 0;
            int number;
            Console.WriteLine("Вводьте числа для обчислення суми (0 для завершення):");
            while ((number = Convert.ToInt32(Console.ReadLine())) != 0)
            {
                sum += number;
            }
            Console.WriteLine("Сума: " + sum);

            // Завдання 3
            string password;
            do
            {
                Console.Write("Введіть пароль: ");
                password = Console.ReadLine();
                if (password != "1234")
                {
                    Console.WriteLine("Неправильний пароль!");
                }
            } while (password != "1234");
            Console.WriteLine("Доступ дозволено!");
        }
    }
}
