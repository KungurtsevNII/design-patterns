using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Observer.ObserverStrongType
{
    public class LogFileSaver : ILogSaver
    {
        public void Save(IEnumerable<string> logs)
        {
            Console.WriteLine("Имитация записи в бд");
            logs.ToList().ForEach(Console.WriteLine);
        }
    }
}