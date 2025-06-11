using System;
using System.Collections.Generic;

namespace LAB18
{
    // Завдання 1
    public interface IAnimal
    {
        void Speak();
        void Eat();
    }

    public class Dog : IAnimal
    {
        public void Speak() => Console.WriteLine("Собака каже: Гав-гав!");
        public void Eat() => Console.WriteLine("Собака їсть.");
    }

    public class Cat : IAnimal
    {
        public void Speak() => Console.WriteLine("Кішка каже: Мяу!");
        public void Eat() => Console.WriteLine("Кішка їсть.");
    }

    // Завдання 2
    public interface IPaymentMethod
    {
        void Pay(decimal amount);
    }

    public class CreditCard : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Оплата кредитною карткою: {amount} грн");
        }
    }

    public class PayPal : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Оплата через PayPal: {amount} грн");
        }
    }

    public class ApplePay : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Оплата через ApplePay: {amount} грн");
        }
    }

    public class Order
    {
        public IPaymentMethod PaymentMethod { get; set; }

        public Order(IPaymentMethod paymentMethod)
        {
            PaymentMethod = paymentMethod;
        }

        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Обробка платежу...");
            PaymentMethod.Pay(amount);
            Console.WriteLine("Платіж виконано.\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Завдання 1 ===");
            List<IAnimal> animals = new List<IAnimal>
            {
                new Dog(),
                new Cat()
            };

            foreach (var animal in animals)
            {
                animal.Speak();
                animal.Eat();
                Console.WriteLine();
            }

            Console.WriteLine("=== Завдання 2 ===");
            Order order1 = new Order(new CreditCard());
            order1.ProcessPayment(500);

            Order order2 = new Order(new PayPal());
            order2.ProcessPayment(250);

            Order order3 = new Order(new ApplePay());
            order3.ProcessPayment(300);
        }
    }
}
