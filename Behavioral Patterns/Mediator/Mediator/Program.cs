using System;
using System.IO;
using System.Linq;

namespace Mediator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string path = "logs.txt";
            var importer = new LogImporter(new LogReader(path), new LogSaver());
            Console.WriteLine(importer.ImportLog());
        }
    }
}