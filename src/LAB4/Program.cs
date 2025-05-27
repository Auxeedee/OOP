using System;

namespace LAB4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Завдання 1: Оголошення змінних
            int age = 17;
            double weight = 60;
            char grade = 'A';
            bool isStudent = true;
            string name = "Микола";

            Console.WriteLine("Завдання 1: Оголошення змінних");
            Console.WriteLine($"Вік: {age}");
            Console.WriteLine($"Вага: {weight}");
            Console.WriteLine($"Оцінка: {grade}");
            Console.WriteLine($"Студент: {isStudent}");
            Console.WriteLine($"Ім'я: {name}");
            Console.WriteLine();

            // Завдання 2: Перетворення типів
            Console.WriteLine("Завдання 2: Перетворення типів");
            Console.Write("Введіть дробове число: ");
            string input = Console.ReadLine();
            double numberDouble = Convert.ToDouble(input);
            int numberInt = (int)numberDouble;
            string numberString = numberInt.ToString();

            Console.WriteLine($"Double: {numberDouble}");
            Console.WriteLine($"Int: {numberInt}");
            Console.WriteLine($"String: {numberString}");
            Console.WriteLine();

            // Завдання 3: Консольний ввід/вивід
            Console.WriteLine("Завдання 3: Консольний ввід/вивід");
            Console.Write("Введіть ваше ім'я: ");
            string userName = Console.ReadLine();
            Console.Write("Введіть ваш вік: ");
            int userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Привіт, {userName}! Твій вік: {userAge} років.");
            Console.WriteLine();

            // Завдання 4: Арифметичні операції
            Console.WriteLine("Завдання 4: Арифметичні операції");
            Console.Write("Введіть відстань (км): ");
            double distance = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть час (год): ");
            double time = Convert.ToDouble(Console.ReadLine());
            double speed = distance / time;
            Console.WriteLine($"Середня швидкість: {speed} км/год");
            Console.WriteLine();

            // Завдання 5: Робота з рядками
            Console.WriteLine("Завдання 5: Робота з рядками");
            Console.Write("Введіть речення: ");
            string sentence = Console.ReadLine();
            Console.WriteLine($"Довжина: {sentence.Length} символів");
            Console.WriteLine($"Верхній регістр: {sentence.ToUpper()}");
            Console.WriteLine($"Замінені пробіли: {sentence.Replace(' ', '_')}");
            Console.WriteLine($"Перші 5 символів: {sentence.Substring(0, Math.Min(5, sentence.Length))}");
        }
    }
}
