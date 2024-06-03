using System;
using System.IO;

namespace CounterApp;

public class Program
{
    public static void CounterApp()
    {
        string filePath = "C:\\test\\CounterVolume";

        if (!File.Exists(filePath))
        {
            File.WriteAllText(filePath, "0");
        }

        string countText = File.ReadAllText(filePath);
        int count = int.Parse(countText);

        count++;

        File.WriteAllText(filePath, count.ToString());

        Console.WriteLine($"The program has been run {count} times.");
    }
}
