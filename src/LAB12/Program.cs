using System;

namespace lab12
{
    // Завдання 1
    struct Point
    {
        public double X { get; }
        public double Y { get; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double DistanceTo(Point other)
        {
            return Math.Sqrt(Math.Pow(other.X - X, 2) + Math.Pow(other.Y - Y, 2));
        }
    }

    // Завдання 2
    class Car
    {
        public string Brand { get; }
        public string Model { get; }
        public int Year { get; }
        public string Color { get; }

        public Car(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }

        public Car(string brand, string model, int year)
            : this(brand, model)
        {
            Year = year;
        }

        public Car(string brand, string model, int year, string color)
            : this(brand, model, year)
        {
            Color = color;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Авто: {Brand} {Model}, Рік: {Year}, Колір: {Color}");
        }
    }

    // Тест
    class Program
    {
        static void Main()
        {
            // Завдання 1
            Point p1 = new Point(3, 4);
            Point p2 = new Point(6, 8);
            Console.WriteLine($"Відстань між точками: {p1.DistanceTo(p2)}");

            // Завдання 2
            Car car1 = new Car("BMW", "X5");
            Car car2 = new Car("Audi", "A4", 2019);
            Car car3 = new Car("Mercedes", "C-Class", 2021, "Чорний");
            car1.ShowInfo();
            car2.ShowInfo();
            car3.ShowInfo();
        }
    }
}
