using System;

namespace LAB21
{
    // Завдання 1: Узагальнений контейнер
    public class Container<T>
    {
        public T Value { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"Значення: {Value}, Тип: {Value.GetType().Name}");
        }
    }

    // Завдання 2: Узагальнений метод для знаходження максимуму
    public static class Utils
    {
        public static T FindMax<T>(T[] array) where T : IComparable<T>
        {
            T max = array[0];
            foreach (T item in array)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }
            return max;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Завдання 1 ===");
            Container<int> intBox = new Container<int> { Value = 100 };
            Container<string> strBox = new Container<string> { Value = "Привіт" };
            intBox.ShowInfo();
            strBox.ShowInfo();

            Console.WriteLine("\n=== Завдання 2 ===");
            int[] intArr = { 1, 5, 3, 9 };
            double[] doubleArr = { 1.1, 2.5, 0.3 };
            string[] stringArr = { "яблуко", "банан", "груша" };

            Console.WriteLine($"Максимум (int): {Utils.FindMax(intArr)}");
            Console.WriteLine($"Максимум (double): {Utils.FindMax(doubleArr)}");
            Console.WriteLine($"Максимум (string): {Utils.FindMax(stringArr)}");
        }
    }
}
