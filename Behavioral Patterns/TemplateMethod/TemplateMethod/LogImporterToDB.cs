using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace TemplateMethod
{
    public class LogImporterToDB : LogImporterBase
    {
        protected override IEnumerable<string> ReadFromFile(string fileName)
        {
            Console.WriteLine($"Чтение из файла {fileName}");
            return new[]
            {
                "string1",
                "string2"
            };
        }

        protected override void Save(IEnumerable<string> logs)
        {
            Console.WriteLine("Запись в бд");
            logs.ToList().ForEach(Console.WriteLine);
        }
    }
}