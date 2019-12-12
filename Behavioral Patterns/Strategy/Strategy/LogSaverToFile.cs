using System;
using System.Collections.Generic;
using System.Linq;

namespace Strategy
{
    /// <summary>
    /// Конкретная реализация поведния,
    /// которая имитирует запись в ТЕКСТОВЫЙ ФАЙЛ. 
    /// </summary>
    public class LogSaverToFile : ILogSaver
    {
        public void Save(IEnumerable<string> logs)
        {
            Console.WriteLine("Я записываю логи в файл.");
            logs.ToList().ForEach(Console.WriteLine);
        }
    }
}