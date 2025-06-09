using System;
using System.Collections.Generic;

namespace LAB13
{
    // 2 завдання
    class Order
    {
        public event EventHandler<string> OrderStatusChanged;
        private string status;
        public string Status
        {
            get => status;
            set
            {
                if (status != value)
                {
                    status = value;
                    OnOrderStatusChanged(status);
                }
            }
        }
        protected virtual void OnOrderStatusChanged(string status)
        {
            OrderStatusChanged?.Invoke(this, status);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1 завдання
            Console.WriteLine("ЗАВДАННЯ 1:");
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Predicate<int> isEven = n => n % 2 == 0;
            int[] evenNumbers = Filter(numbers, isEven);
            Console.WriteLine("Парні числа:");
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }

            // 2 завдання
            Console.WriteLine("\nЗАВДАННЯ 2:");
            Order order = new Order();
            order.OrderStatusChanged += OrderStatusChangedHandler;
            order.Status = "Замовлення отримано";
            order.Status = "Відправлено";
            order.Status = "Доставлено";
        }

        // 1 завдання
        static int[] Filter(int[] numbers, Predicate<int> predicate)
        {
            List<int> result = new List<int>();
            foreach (var number in numbers)
            {
                if (predicate(number))
                    result.Add(number);
            }
            return result.ToArray();
        }

        // 2 завдання
        static void OrderStatusChangedHandler(object sender, string status)
        {
            Console.WriteLine($"Статус замовлення змінено на: {status}");
        }
    }
}
