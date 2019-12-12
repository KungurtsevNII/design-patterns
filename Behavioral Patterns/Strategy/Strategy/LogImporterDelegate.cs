using System;
using System.Collections.Generic;

namespace Strategy
{
    /// <summary>
    /// Context (LogImporter) — является клиентом стратегии;
    /// Реализация паттерна через делегаты.
    /// </summary>
    public class LogImporterDelegate
    {
        private readonly Action<IEnumerable<string>> _saver;

        public LogImporterDelegate(Action<IEnumerable<string>> saver)
        {
            _saver = saver;
        }
        public void Import()
        {
            // Имитация получения логов.
            var logs = new[]
            {
                "string1",
                "string2"
            };
            
            // Контекст не знает, какую логику поведения реализует.
            _saver.Invoke(logs);
        }
        
    }
}