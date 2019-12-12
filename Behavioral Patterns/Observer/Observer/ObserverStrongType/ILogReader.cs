using System.Collections.Generic;

namespace Observer.ObserverStrongType
{
    public interface ILogReader
    {
        void AddSaver(ILogSaver saver);
        
        void RemoveSaver(ILogSaver saver);
        
        void Save(IEnumerable<string> logs);
    }
}