using System;
using System.Collections.Generic;

public class LAB25
{
    // Завдання 1
    public interface ICalculationStrategy
    {
        int Calculate(int a, int b);
    }

    public class AddStrategy : ICalculationStrategy
    {
        public int Calculate(int a, int b) => a + b;
    }

    public class SubtractStrategy : ICalculationStrategy
    {
        public int Calculate(int a, int b) => a - b;
    }

    public class MultiplyStrategy : ICalculationStrategy
    {
        public int Calculate(int a, int b) => a * b;
    }

    public class Calculator
    {
        private ICalculationStrategy _strategy;

        public Calculator(ICalculationStrategy strategy)
        {
            _strategy = strategy;
        }

        public int Execute(int a, int b) => _strategy.Calculate(a, b);
    }

    // Завдання 2
    public interface ICommand
    {
        void Execute();
    }

    public class OpenFileCommand : ICommand
    {
        public void Execute() => Console.WriteLine("Файл відкрито");
    }

    public class SaveFileCommand : ICommand
    {
        public void Execute() => Console.WriteLine("Файл збережено");
    }

    public class CloseFileCommand : ICommand
    {
        public void Execute() => Console.WriteLine("Файл закрито");
    }

    public class Editor
    {
        public void Submit(ICommand command) => command.Execute();
    }

    // Завдання 3
    public interface IChatMediator
    {
        void Send(string message, User user);
    }

    public class ChatRoom : IChatMediator
    {
        private List<User> _users = new();

        public void Register(User user) => _users.Add(user);

        public void Send(string message, User sender)
        {
            foreach (var user in _users)
            {
                if (user != sender)
                    user.Receive(message);
            }
        }
    }

    public class User
    {
        public string Name { get; }
        private IChatMediator _mediator;

        public User(string name, IChatMediator mediator)
        {
            Name = name;
            _mediator = mediator;
        }

        public void Send(string msg) => _mediator.Send(msg, this);
        public void Receive(string msg) => Console.WriteLine($"{Name} отримав: {msg}");
    }

    // Завдання 4
    public interface IObserver
    {
        void Update(string message);
    }

    public class PhoneApp : IObserver
    {
        private string _id;
        public PhoneApp(string id) => _id = id;

        public void Update(string message) => Console.WriteLine($"Додаток {_id}: {message}");
    }

    public class Billboard : IObserver
    {
        private string _location;
        public Billboard(string location) => _location = location;

        public void Update(string message) => Console.WriteLine($"Білборд ({_location}): {message}");
    }

    public class WeatherStation
    {
        private List<IObserver> _subscribers = new();

        public void Subscribe(IObserver observer) => _subscribers.Add(observer);

        public void Notify(string message)
        {
            foreach (var observer in _subscribers)
                observer.Update(message);
        }
    }

    public static void Main()
    {
        // Завдання 1
        Console.WriteLine("=== Стратегія ===");
        Calculator calc = new Calculator(new AddStrategy());
        Console.WriteLine("10 + 5 = " + calc.Execute(10, 5));
        calc = new Calculator(new MultiplyStrategy());
        Console.WriteLine("10 * 5 = " + calc.Execute(10, 5));

        // Завдання 2
        Console.WriteLine("\n=== Команда ===");
        Editor editor = new Editor();
        editor.Submit(new OpenFileCommand());
        editor.Submit(new SaveFileCommand());
        editor.Submit(new CloseFileCommand());

        // Завдання 3
        Console.WriteLine("\n=== Посередник ===");
        ChatRoom chat = new ChatRoom();
        User alice = new User("Михайло", chat);
        User bob = new User("Олексій", chat);
        chat.Register(alice);
        chat.Register(bob);
        alice.Send("Привіт, Олексію!");
        bob.Send("Вітаю, Михайле!");

        // Завдання 4
        Console.WriteLine("\n=== Спостерігач ===");
        WeatherStation station = new WeatherStation();
        station.Subscribe(new PhoneApp("Додаток-01"));
        station.Subscribe(new Billboard("Центр міста"));
        station.Notify("Оновлення погоди: +17°C, Сонячно");
    }
}
