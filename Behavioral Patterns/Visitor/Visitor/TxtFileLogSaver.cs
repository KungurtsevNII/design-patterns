using System;
using Visitor.LogEntry;

namespace Visitor
{
    public class TxtFileLogSaver : ILogEntryVisitor
    {
        public void Visit(SimpleLogEntry simpleLogEntry)
        {
            Console.WriteLine($"Простые логи сохраняются в файл: {simpleLogEntry.Message}, {simpleLogEntry.AdditionalInfo}");
        }

        public void Visit(ExceptionLogEntry exceptionLogEntry)
        {
            Console.WriteLine($"Логи с ошибкой сохраняются в файл: {exceptionLogEntry.Message}, {exceptionLogEntry.Exception}");
        }
    }
}