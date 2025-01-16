using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "C:\\Users\\melni\\OneDrive\\Рабочий стол\\input.txt";


        List<string> lines = new List<string>();

        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();
        try
        {
            foreach (string line in File.ReadLines(filePath))
            {
                lines.Add(line);
            }

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Произошла ошибка: " + ex.Message);
        }
        stopWatch.Stop();
        TimeSpan ts = stopWatch.Elapsed;

        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime);
    }
}