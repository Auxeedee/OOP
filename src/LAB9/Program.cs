using System;

namespace LAB9
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { 8, 5, 2, 9, 1, 5, 6 };
            int swapCount = 0;

            // Алгоритм бульбашкового сортування з підрахунком перестановок
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - 1 - i; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        // Перестановка елементів
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                        swapCount++;
                    }
                }
            }

            // Вивід результатів
            Console.WriteLine("Кількість перестановок: " + swapCount);
            Console.Write("Після сортування: [");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]);
                if (i < numbers.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine("]");
        }
    }
}
