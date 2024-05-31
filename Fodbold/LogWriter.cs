﻿using System.Diagnostics;
using System.Reflection;

namespace Fodbold;
public class LogWriter
{
    //Hjemmelavet logwriter TM-Aksel
    private readonly string logFilePath;
    public LogWriter()
    {
        logFilePath = GetLogFilePath();
    }
    private string GetLogFilePath()
    {
        string exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        string logFileName = $"log{DateTime.Now.ToString("MM-dd-yy")}.FootBallLogs";
        string logFolderPath = Path.Combine(exePath, "Logs");
        string finalLogFilePath = Path.Combine(logFolderPath, logFileName);
        if (!Directory.Exists(logFolderPath))
        {
            Directory.CreateDirectory(logFolderPath);
            Console.WriteLine("Logs folder created.");
        }
        return finalLogFilePath;
    }
    private static readonly object fileLock = new object();
    public void LogWrite(string logMessage)
    {
        lock (fileLock)
        {
            try
            {
                using (StreamWriter writer = File.AppendText(logFilePath))
                {
                    Log(logMessage, writer);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error writing to log file: {ex.Message}");
            }
        }
    }
    //smider det i din app/bin/debug/net8.0/logs folder som den opretter
    private void Log(string logMessage, TextWriter txtWriter)
    {
        try
        {
            txtWriter.Write("\r\nLog Entry :");
            txtWriter.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            txtWriter.WriteLine(" - {0}", logMessage);
            txtWriter.WriteLine("--------------------------");
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Error logging message: {ex.Message}");
        }
    }
}
