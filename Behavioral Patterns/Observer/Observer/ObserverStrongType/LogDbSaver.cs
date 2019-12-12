using System;
using System.Collections.Generic;
using System.Linq;

namespace Observer.ObserverStrongType
{
    public class LogDbSaver : ILogSaver
    {
        public void Save(IEnumerable<string> logs)
        {
            Console.WriteLine("Имитация записи в файл");
            logs.ToList().ForEach(Console.WriteLine);
        }
    }
}