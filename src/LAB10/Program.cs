using System;
using System.Collections.Generic;

namespace lab10
{
    class MortgageCalculator
    {
        public static void Main()
        {
            CalculateMortgage();
            RequestQueue.ManageQueue();
        }

        static void CalculateMortgage()
        {
            Console.Write("Введіть суму кредиту: ");
            decimal P = decimal.Parse(Console.ReadLine());

            Console.Write("Введіть річну відсоткову ставку (%): ");
            decimal r = decimal.Parse(Console.ReadLine()) / 1200;

            Console.Write("Введіть термін кредиту (у роках): ");
            int n = int.Parse(Console.ReadLine()) * 12;

            decimal M = P * (r * (decimal)Math.Pow((double)(1 + r), n)) /
                        ((decimal)Math.Pow((double)(1 + r), n) - 1);

            Console.WriteLine($"Щомісячний платіж: {Math.Round(M, 2)} грн");
        }
    }

    class RequestQueue
    {
        static Queue<string> queue = new Queue<string>();

        public static void ManageQueue()
        {
            while (true)
            {
                Console.WriteLine("\n1. Додати заявку");
                Console.WriteLine("2. Обробити заявку");
                Console.WriteLine("3. Переглянути першу заявку");
                Console.WriteLine("4. Переглянути всі заявки");
                Console.WriteLine("5. Вихід");

                string choice = Console.ReadLine();
                if (choice == "5") break;

                switch (choice)
                {
                    case "1":
                        Console.Write("Введіть текст заявки: ");
                        queue.Enqueue(Console.ReadLine());
                        break;
                    case "2":
                        Console.WriteLine(queue.Count > 0 ? $"Оброблено: {queue.Dequeue()}" : "Черга порожня.");
                        break;
                    case "3":
                        Console.WriteLine(queue.Count > 0 ? $"Перша заявка: {queue.Peek()}" : "Черга порожня.");
                        break;
                    case "4":
                        if (queue.Count == 0)
                        {
                            Console.WriteLine("Черга порожня.");
                        }
                        else
                        {
                            Console.WriteLine("Усі заявки:");
                            foreach (var item in queue)
                                Console.WriteLine(item);
                        }
                        break;
                    default:
                        Console.WriteLine("Невірний вибір.");
                        break;
                }
            }
        }
    }
}
