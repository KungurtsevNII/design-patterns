using System;
using System.Reactive.Subjects;

namespace Observer.ObserverByRx
{
    /// <summary>
    /// Реактивные последовательности1 являются своеобразной смесью паттернов «Ите-
    /// ратор» и «Наблюдатель». IObservable можно рассматривать как «вывернутые наиз-
    /// нанку» последовательности, когда процессом итерирования управляет не вызывающая
    /// сторона, как в случае с IEnumerable, а сама последовательность. 
    /// </summary>
    public class LogFileReader : IDisposable
    {
        private readonly string _fileName;
        
        /// <summary>
        /// Субъект подписки.
        /// </summary>
        private readonly Subject<string> _logEntriesSubject = new Subject<string>();
        
        /// <summary>
        /// Приводим к интерфейсу.
        /// </summary>
        public IObservable<string> NewMessages => _logEntriesSubject;

        public bool HasObservers => _logEntriesSubject.HasObservers;
        
        public LogFileReader(string fileName)
        {
            _fileName = fileName;
        }
        
        public void Dispose()
        {
            // Уведомляем подписчиков, что событий больше не будет
            _logEntriesSubject.OnCompleted();
        }
        
        
        public void CheckFile()
        {
            // Отправляем найденные логи.
            _logEntriesSubject.OnNext("Logs...");
            _logEntriesSubject.OnNext("Logs1...");
            _logEntriesSubject.OnNext("Logs2...");
            _logEntriesSubject.OnNext("Logs3...");     
        }
    }
}