using System;

namespace Observer.ObserverByEvent
{
    /// <summary>
    /// Subject (наблюдаемый объект).
    /// Наблюдатель уведомляет все заинтересованные
    /// стороны о произошедшем событии или об изменении своего состояния.
    /// Отношение объектов 1(Subject) : N(Observers).
    /// </summary>
    public class LogFileReader
    {
        private readonly string _logFileName;
        // Событие, на которое подписываются.
        public event EventHandler<LogEntryEventArgs> OnNewLogEntry;
        
        public LogFileReader(string logFileName)
        {
            _logFileName = logFileName;
        }

        /// <summary>
        /// Проверка на наличие новоиспеченных логов.
        /// </summary>
        public void CheckFile()
        {
            // Имитация на проверку новых логов в файле.
            string logs = "Логи..";
            // Оповещение всех о том, что пришли новые логи.
            Notify(logs);
        }
        
        /// <summary>
        /// Оповещение. Вызов события.
        /// </summary>
        /// <param name="logEntry"></param>
        private void Notify(string logEntry)
        {
            var handler = OnNewLogEntry;
            handler?.Invoke(this, new LogEntryEventArgs(logEntry));
        }
    }
}