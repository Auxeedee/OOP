using System;

namespace LAB_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
        }

        //Тут виконуєте завдання №1
        private static void Task1()
        {
            int userAge = 20; 
            string userName = "Андрій"; 
            Console.WriteLine("Привіт, " + userName + "! Твій вік: " + userAge);
        }

        //Тут виконуєте завдання №2
        private static void Task2()
        {
            int userAge = 20; // Назва змінної у CamelCase
            string userName = "Андрій"; // Назва змінної у CamelCase
            Console.WriteLine("Привіт, " + userName + "! Твій вік: " + userAge);
        }


        //Тут виконуєте завдання №3
        private static void Task3()
        {
            string name = "Анна"; // Оголошення зміннох для імя
            int age = 25; // Оголошення змінної для віку
            Console.WriteLine("Привіт, " + name + "! Твій вік: " + age); // Виводимо Привіт + імя + вік
        }
    }
}