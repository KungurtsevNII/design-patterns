using System;
using System.IO;

namespace Observer.ObserverByDelegate
{
    /// <summary>
    /// Subject (наблюдаемый объект).
    /// Отношение объектов 1(Subject) : 1(Observer).
    /// </summary>
    public class LogFileReader
    {
        private readonly string _logFileName;
        // Уведомление клиентского кода, через делегат.
        private readonly Action<string> _logEntrySubscriber;

        public LogFileReader(string logFileName, Action<string> logEntrySubscriber)
        {
            _logFileName = logFileName;
            _logEntrySubscriber = logEntrySubscriber;
        }

        /// <summary>
        /// Проверка на новые логи в файле.
        /// </summary>
        public void CheckFile()
        {
            // Имитация проверки.
            string log = "Логи...";
            Notify(log);
        }

        /// <summary>
        /// Оповещение подписчика.
        /// </summary>
        /// <param name="log"></param>
        private void Notify(string log)
        {
            _logEntrySubscriber(log);
        }
    }
}