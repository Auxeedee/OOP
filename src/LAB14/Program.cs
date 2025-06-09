using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

class LAB14
{
    static void Main()
    {
        string[] fileNames = { "log1.txt", "log2.txt", "log3.txt" };
        CreateLogFiles(fileNames, 10000);
        Task[] tasks = new Task[fileNames.Length];
        for (int i = 0; i < fileNames.Length; i++)
        {
            int fileIndex = i;
            tasks[i] = Task.Run(() => ProcessFile(fileNames[fileIndex]));
        }
        Task.WhenAll(tasks).Wait();
        Console.WriteLine("Обробку файлів завершено!");
    }

    static void CreateLogFiles(string[] fileNames, int linesPerFile)
    {
        Random rnd = new Random();
        foreach (var fileName in fileNames)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                for (int i = 0; i < linesPerFile; i++)
                {
                    if (rnd.Next(100) < 10)
                    {
                        writer.WriteLine("ПОМИЛКА: Щось пішло не так!");
                    }
                    else
                    {
                        writer.WriteLine("ІНФО: Все працює нормально.");
                    }
                }
            }
        }
        Console.WriteLine("Файли успішно створено.");
    }

    static void ProcessFile(string fileName)
    {
        int errorCount = 0;
        try
        {
            var lines = File.ReadAllLines(fileName);
            foreach (var line in lines)
            {
                if (line.Contains("ПОМИЛКА"))
                {
                    errorCount++;
                }
            }
            Console.WriteLine($"Файл {fileName}: Знайдено {errorCount} помилок.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка при обробці файлу {fileName}: {ex.Message}");
        }
    }
}
