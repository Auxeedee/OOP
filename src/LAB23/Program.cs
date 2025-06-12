using System;

namespace LAB23
{
    // Завдання 1
    class Logger
    {
        private static Logger _instance;
        private Logger() { }
        public static Logger Instance => _instance ??= new Logger();
        public void Log(string msg) => Console.WriteLine($"[Журнал] {DateTime.Now}: {msg}");
    }

    // Завдання 2
    interface INotification { void Send(string msg); }

    class Email : INotification
    {
        public void Send(string msg) => Console.WriteLine("Електронна пошта: " + msg);
    }

    class SMS : INotification
    {
        public void Send(string msg) => Console.WriteLine("СМС: " + msg);
    }

    class NotifyFactory
    {
        public static INotification Create(string type) => type switch
        {
            "email" => new Email(),
            "sms" => new SMS(),
            _ => throw new Exception("Невідомий тип")
        };
    }

    // Завдання 3
    class Computer
    {
        public string CPU, GPU;
        public void Show() => Console.WriteLine($"ПК з {CPU}, {GPU}");
    }

    class PCBuilder
    {
        private Computer pc = new();
        public PCBuilder SetCPU(string cpu) { pc.CPU = cpu; return this; }
        public PCBuilder SetGPU(string gpu) { pc.GPU = gpu; return this; }
        public Computer Build() => pc;
    }

    class Program
    {
        static void Main()
        {
            // Завдання 1
            Logger.Instance.Log("Програма запущена");

            // Завдання 2
            var n = NotifyFactory.Create("email");
            n.Send("Фабрика працює!");

            // Завдання 3
            var myPC = new PCBuilder().SetCPU("i7").SetGPU("RTX").Build();
            myPC.Show();
        }
    }
}
