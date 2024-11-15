using System;
using System.IO;

namespace Logging
{
    public delegate void LogDelegate(string message, int level = 3);

    internal class Program
    {
        static void Main(string[] args)
        {
            FileLogger fileLogger = new FileLogger();

            LogDelegate logger = ConsoleLog;
            logger("Program elindult!");

            logger = fileLogger.FileLog;
            logger("Logolunk file-ba");

            logger = DatabaseLog;
            logger("Még egy adatbázis log bejegyzés");

            logger = fileLogger.FileLog;
            logger("Fájlba logolás", 2);

            logger = ConsoleLog;
            logger("Program leáll....");

            Console.ReadLine();
        }

        public static void ConsoleLog(string message, int level)
        {
            Console.WriteLine($"[Console Log] Level {level}: {message}");
        }

        public static void FileLog(string message, int level)
        {
            string path = "log.txt";
            File.AppendAllText(path, $"[File Log] Level {level}: {message}\n");
        }

        public static void DatabaseLog(string message, int level)
        {
            Console.WriteLine($"[Database Log] Level {level}: {message} (simulated database log)");
        }
    }

    internal class FileLogger
    {
        private string pathError = "log_error.txt";
        private string pathDebug = "log_debug.txt";

        public FileLogger() {}
        public FileLogger(string path)
        {
            this.pathError = path;
        }

        public void FileLog(string message, int level)
        {
            if (level < 3)
            {
                File.AppendAllText(pathError, $"[File Log] Level {level}: {message}\n");
            }
            {
                File.AppendAllText(pathDebug, $"[File Log] Level {level}: {message}\n");
            }
        }
    }
}