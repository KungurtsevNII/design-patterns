using Visitor.LogEntry;

namespace Visitor
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Логи.
            var exceptionLog = new ExceptionLogEntry
            {
                Exception = "ArgumentOutOfRange",
                Message = "Ошибка. Беда"
            };

            var simpleLog = new SimpleLogEntry
            {
                Message = "Логи. Логи.",
                AdditionalInfo = "Доп инфа."
            };
            
            // Посетители. 
            var databaseSaver = new DatabaseLogSaver();
            var txtFileSaver = new TxtFileLogSaver();
            
            // Созранение логов.
            databaseSaver.Visit(simpleLog);
            databaseSaver.Visit(exceptionLog);
            
            txtFileSaver.Visit(simpleLog);
            txtFileSaver.Visit(exceptionLog);
        }
    }
}