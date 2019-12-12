using System.Collections.Generic;
using System.Linq;

namespace Mediator
{
    public class LogSaver
    {
        /// <summary>
        /// Заглушка на запись логов в бд.
        /// </summary>
        /// <param name="logs">Массив логов</param>
        /// <returns>
        /// Кол-во записанных строк. 
        /// </returns>
        public int SaveLogToSqlServer(IEnumerable<string> logs)
        {
            return logs.Count();
        }
    }
}