using System.Collections.Generic;

namespace TemplateMethod
{
    /// <summary>
    /// Реализация паттерна ПОВЕДЕНИЯ "Шаблонный метод".
    /// Шаблонный метод определяет основу алгоритма
    /// и позволяет подклассам переопределять некоторые шаги алгоритма,
    /// не изменяя его структуры в целом.
    /// </summary>
    public abstract class LogImporterBase
    {
        /// <summary>
        /// Комплексная операция по импорту
        /// логов из одного источника в другой
        /// </summary>
        /// <param name="fileName"></param>
        public void Import(string fileName)
        {
            Save(ReadFromFile(fileName));
        }

        /// <summary>
        /// Примитивная операция считывания из файла.
        /// Логика определяется в дочернем классе
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        protected abstract IEnumerable<string> ReadFromFile(string fileName);
        
        
        /// <summary>
        /// Примитивная операция сохранения в другой источник.
        /// Логика определяется в дочернем классе.
        /// </summary>
        /// <param name="logs"></param>
        protected abstract void Save(IEnumerable<string> logs);
    }
}