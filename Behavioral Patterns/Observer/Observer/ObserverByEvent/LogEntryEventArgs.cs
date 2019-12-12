namespace Observer.ObserverByEvent
{
    public class LogEntryEventArgs
    {
        public string LogEntry { get; internal set; }

        public LogEntryEventArgs(string logEntry)
        {
            LogEntry = logEntry;
        }
    }
}