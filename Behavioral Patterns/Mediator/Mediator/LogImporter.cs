namespace Mediator
{
    /// <summary>
    /// Паттерн Медиатор.
    /// Класс LogImporter выступает в роли посредника: он связывает воедино не-
    /// сколько низкоуровневых классов для обеспечения нового высокоуровневого
    /// поведения. Такой подход обеспечивает гибкость в развитии системы, хотя и не
    /// вводит полиморфного поведения. Посредник в этом случае выступает барьером,
    /// который гасит изменения в одной части системы, не давая им распространяться
    /// на другие части! Любые изменения в классе LogFileReader приведут к моди-
    /// фикации LogImporter, но не потребуют изменений класса LogFileSaver или
    /// его клиентов.
    /// </summary>
    public class LogImporter
    {
        private readonly LogReader _reader;
        private readonly LogSaver _saver;
        
        public LogImporter(LogReader reader, LogSaver saver)
        {
            _reader = reader;
            _saver = saver;
        }

        public int ImportLog()
        {
            return _saver.SaveLogToSqlServer(_reader.ReadLog());
        }
    }
}