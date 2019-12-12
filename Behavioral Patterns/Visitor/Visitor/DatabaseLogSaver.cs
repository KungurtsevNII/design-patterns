using System;
using Visitor.LogEntry;

namespace Visitor
{
    /// <summary>
    /// Client (DatabaseLogSaver) — использует посетитель для обработки
    /// иерархии элементов.
    /// </summary>
    public class DatabaseLogSaver : ILogEntryVisitor
    {
        public void Visit(SimpleLogEntry simpleLogEntry)
        {
            Console.WriteLine($"Простые логи сохраняются в БД: {simpleLogEntry.Message}, {simpleLogEntry.AdditionalInfo}");
        }

        public void Visit(ExceptionLogEntry exceptionLogEntry)
        {
            Console.WriteLine($"Логи с ошибкой сохраняются в БД: {exceptionLogEntry.Message}, {exceptionLogEntry.Exception}");
        }
    }
}