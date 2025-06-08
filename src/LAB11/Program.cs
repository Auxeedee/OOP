using System;
using System.Collections.Generic;
using System.Linq;

namespace lab11
{
    class Program
    {
        static void Main()
        {
            // Завдання 1
            SupportRequestSystem();

            // Завдання 2
            WordFrequencyAnalyzer();
        }

        // Завдання 1: Система обробки заявок
        static void SupportRequestSystem()
        {
            Queue<string> requestQueue = new Queue<string>();

            while (true)
            {
                Console.WriteLine("\nМеню:");
                Console.WriteLine("1. Додати заявку");
                Console.WriteLine("2. Обробити заявку");
                Console.WriteLine("3. Переглянути першу заявку");
                Console.WriteLine("4. Показати всі заявки");
                Console.WriteLine("5. Завершити завдання 1");
                Console.Write("Ваш вибір: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Введіть текст заявки: ");
                        string request = Console.ReadLine();
                        requestQueue.Enqueue(request);
                        Console.WriteLine("Заявку додано!");
                        break;
                    case "2":
                        if (requestQueue.Count > 0)
                            Console.WriteLine($"Заявка \"{requestQueue.Dequeue()}\" оброблена!");
                        else
                            Console.WriteLine("Черга порожня!");
                        break;
                    case "3":
                        Console.WriteLine(requestQueue.Count > 0
                            ? $"Перша заявка: {requestQueue.Peek()}"
                            : "Черга порожня!");
                        break;
                    case "4":
                        Console.WriteLine(requestQueue.Count > 0
                            ? $"Усі заявки: {string.Join(", ", requestQueue)}"
                            : "Черга порожня!");
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Невірний вибір! Спробуйте ще раз.");
                        break;
                }
            }
        }

        // Завдання 2: Аналіз частоти слів
        static void WordFrequencyAnalyzer()
        {
            Console.Write("\nВведіть текст: ");
            string input = Console.ReadLine().ToLower();

            char[] separators = { ' ', ',', '.', '!', '?', ';', ':', '\n', '\r', '\t' };
            string[] words = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> frequency = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (frequency.ContainsKey(word))
                    frequency[word]++;
                else
                    frequency[word] = 1;
            }

            var sorted = frequency.OrderByDescending(pair => pair.Value);

            Console.WriteLine("\nСтатистика слів:");
            foreach (var pair in sorted)
                Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}
