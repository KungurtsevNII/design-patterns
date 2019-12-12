using System;

namespace Visitor.LogEntry
{
    /// <summary>
    /// Element (LogEntry) — базовый класс иерархии, для которой нужно добавить
    /// новую операцию
    /// </summary>
    public abstract class LogEntry
    {
        public DateTime DateTime { get; set; }
        
        public string Message { get; set; }
        
        public abstract void Accept(ILogEntryVisitor logEntryVisitor);
    }
}