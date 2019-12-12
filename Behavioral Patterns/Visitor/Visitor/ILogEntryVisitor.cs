using Visitor.LogEntry;

namespace Visitor
{
    /// <summary>
    /// Visitor (ILogEntryVisitor) — определяет интерфейс посетителя;
    ///
    /// Поведенческий паттерн Visitor(посетитель).
    /// Описывает операцию, выполняемую с каждым объектом из некоторой иерархии классов.
    /// Паттерн «Посетитель» позволяет определить новую операцию, не изменяя классов этих объектов.
    /// </summary>
    public interface ILogEntryVisitor
    {
        void Visit(SimpleLogEntry simpleLogEntry);
        
        void Visit(ExceptionLogEntry exceptionLogEntry);
    }
}