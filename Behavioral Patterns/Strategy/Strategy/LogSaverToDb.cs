using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Strategy
{
    /// <summary>
    /// Конкретная реализация поведния,
    /// которая имитирует запись в бд. 
    /// </summary>
    public class LogSaverToDb : ILogSaver
    {
        public void Save(IEnumerable<string> logs)
        {
            Console.WriteLine("Я записываю логи в бд.");
            logs.ToList().ForEach(Console.WriteLine);
        }
    }
}