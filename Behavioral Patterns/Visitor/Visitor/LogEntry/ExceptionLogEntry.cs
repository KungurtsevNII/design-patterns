namespace Visitor.LogEntry
{
    public class ExceptionLogEntry : LogEntry
    {
        public string Exception { get; set; }
        
        public override void Accept(ILogEntryVisitor logEntryVisitor)
        {
            logEntryVisitor.Visit(this);
        }
    }
}