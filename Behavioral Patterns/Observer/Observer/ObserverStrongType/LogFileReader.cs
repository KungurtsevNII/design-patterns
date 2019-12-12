using System.Collections.Generic;

namespace Observer.ObserverStrongType
{
    /// <summary>
    /// Subject (наблюдаемый объект).
    /// Отношение объектов 1(Subject) : N(Observer).
    /// </summary>
    public class LogFileReader : ILogReader
    {
        /// <summary>
        /// Подписчики.
        /// </summary>
        private List<ILogSaver> _savers;
        private readonly string _filename;

        public LogFileReader(string filename)
        {
            _savers = new List<ILogSaver>();
            _filename = filename;
        }

        public void AddSaver(ILogSaver saver)
        {
            _savers.Add(saver);
        }

        public void RemoveSaver(ILogSaver saver)
        {
            _savers.Remove(saver);
        }

        public void Save(IEnumerable<string> logs)
        {
            foreach (var saver in _savers)
            {
                saver.Save(logs);
            }
        }

        public void LogRead()
        {
            // Имитация чтения логов.
            var logs = new[]
            {
                "log",
                "log",
                "log"
            };
            Save(logs);
        }
    }
}