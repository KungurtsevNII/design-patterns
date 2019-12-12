using System.Collections.Generic;

namespace Strategy
{
    /// <summary>
    /// Выделенный интерфейс поведения.
    /// Определяет семейство алгоритмов, инкапсулирует каждый из них
    /// и делает их взаимозаменяемыми. Стратегия позволяет изменять
    /// алгоритмы независимо от клиентов, которые ими пользуются.
    /// </summary>
    public interface ILogSaver
    {
        void Save(IEnumerable<string> logs);
    }
}