using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Mediator
{
    public class LogReader
    {
        private readonly string _logFileName;

        public LogReader(string logFileName)
        {
            _logFileName = logFileName;
        }

        public IEnumerable<string> ReadLog()
        {
            List<string> result = new List<string>();
            if (!File.Exists(_logFileName))
            {
                throw new FileNotFoundException("Файл не найден. Положите файл logs.txt в паку запуска приложения.");
            }
            using (var reader = new StreamReader(_logFileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    result.Add(line);
                }
            }

            return result;
        }
    }
}