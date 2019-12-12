using System.Collections.Generic;

namespace Observer.ObserverStrongType
{
    /// <summary>
    /// Observer — определяет интерфейс наблюдателя;
    /// </summary>
    public interface ILogSaver
    {
        void Save(IEnumerable<string> logs);
    }
}