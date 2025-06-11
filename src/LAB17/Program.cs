using System;

namespace LAB17
{
    public class Student
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0 && value <= 120)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Некоректний вік. Вік має бути від 0 до 120.");
                }
            }
        }
    }

    public class Car
    {
        private int speed;

        public int Speed
        {
            get { return speed; }
        }

        public void Accelerate(int amount)
        {
            speed += amount;
            Console.WriteLine($"Прискорення: +{amount}, поточна швидкість: {speed}");
        }

        public void Brake(int amount)
        {
            if (speed - amount < 0)
            {
                speed = 0;
                Console.WriteLine($"Гальмування: -{amount}, швидкість не може бути менше 0. Поточна швидкість: {speed}");
            }
            else
            {
                speed -= amount;
                Console.WriteLine($"Гальмування: -{amount}, поточна швидкість: {speed}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Тестування Student
            Student student = new Student();
            student.Name = "Олена";
            student.Age = 25;
            Console.WriteLine($"Студент: {student.Name}, Вік: {student.Age}");

            student.Age = -5;

            // Тестування Car
            Car car = new Car();
            car.Accelerate(50);
            car.Brake(20);
            car.Brake(40);
            Console.WriteLine($"Фінальна швидкість: {car.Speed}");
        }
    }
}
