using System;

namespace LAB24
{
    // Завдання 1
    public interface INewPrinter
    {
        void Print(string message);
    }

    public class OldPrinter
    {
        public void OldPrint() => Console.WriteLine("Друк у старому стилі");
    }

    public class PrinterAdapter : INewPrinter
    {
        private readonly OldPrinter _oldPrinter;

        public PrinterAdapter(OldPrinter oldPrinter)
        {
            _oldPrinter = oldPrinter;
        }

        public void Print(string message)
        {
            _oldPrinter.OldPrint();
            Console.WriteLine(message);
        }
    }

    // Завдання 2
    public class Engine
    {
        public void Start() => Console.WriteLine("Двигун запущено");
    }

    public class Battery
    {
        public void Start() => Console.WriteLine("Батарею активовано");
    }

    public class IgnitionSystem
    {
        public void Start() => Console.WriteLine("Систему запалювання активовано");
    }

    public class CarFacade
    {
        private readonly Engine _engine = new Engine();
        private readonly Battery _battery = new Battery();
        private readonly IgnitionSystem _ignitionSystem = new IgnitionSystem();

        public void StartCar()
        {
            _battery.Start();
            _ignitionSystem.Start();
            _engine.Start();
            Console.WriteLine("Автомобіль запущено");
        }
    }

    // Завдання 3
    public interface IWriter
    {
        void Write(string text);
    }

    public class ConsoleWriter : IWriter
    {
        public void Write(string text) => Console.WriteLine(text);
    }

    public class TimestampWriter : IWriter
    {
        private readonly IWriter _inner;

        public TimestampWriter(IWriter inner)
        {
            _inner = inner;
        }

        public void Write(string text)
        {
            string stamped = $"[{DateTime.Now:HH:mm:ss}] {text}";
            _inner.Write(stamped);
        }
    }

    class Program
    {
        static void Main()
        {
            // Завдання 1
            Console.WriteLine("Завдання 1:");
            OldPrinter oldPrinter = new OldPrinter();
            INewPrinter newPrinter = new PrinterAdapter(oldPrinter);
            newPrinter.Print("Це новий виклик");
            Console.WriteLine();

            // Завдання 2
            Console.WriteLine("Завдання 2:");
            CarFacade carFacade = new CarFacade();
            carFacade.StartCar();
            Console.WriteLine();

            // Завдання 3
            Console.WriteLine("Завдання 3:");
            IWriter writer = new TimestampWriter(new ConsoleWriter());
            writer.Write("Привіт, світ!");
        }
    }
}
