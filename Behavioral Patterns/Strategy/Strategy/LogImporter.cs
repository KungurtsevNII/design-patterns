namespace Strategy
{
    /// <summary>
    /// Context (LogImporter) — является клиентом стратегии;
    /// </summary>
    public class LogImporter
    {
        // Стратегия сохранения.
        private readonly ILogSaver _saver;

        public LogImporter(ILogSaver saver)
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
            _saver.Save(logs);
        }

    }
}