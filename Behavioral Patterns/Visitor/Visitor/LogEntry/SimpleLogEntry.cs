namespace Visitor.LogEntry
{
    public class SimpleLogEntry : LogEntry
    {
        public string AdditionalInfo { get; set; }
        
        public override void Accept(ILogEntryVisitor logEntryVisitor)
        {
            logEntryVisitor.Visit(this);
        }
    }
}