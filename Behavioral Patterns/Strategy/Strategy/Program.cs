using System;
using System.Linq;

namespace Strategy
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var logImporter = new LogImporter(new LogSaverToDb());
            var logImporterToFile = new LogImporter(new LogSaverToFile());
            var logImporterDelegate = new LogImporterDelegate(x =>
            {
                Console.WriteLine("Я пишу логи куда-то, но черезе делегаты.");
                x.ToList().ForEach(Console.WriteLine);
            });
            
            
            logImporter.Import();
            logImporterToFile.Import();
            logImporterDelegate.Import();
        }
    }
}