using System;

namespace Singleton.App
{
    public class SingletonDoubleCheckLock
    {
        private static int InstanceCount { get; set; }
        
        /// <summary>
        /// Объект SingletonDoubleCheckLock.
        /// </summary>
        private static volatile SingletonDoubleCheckLock _instance;
        
        /// <summary>
        /// Объект синхронизации. 
        /// </summary>
        private static readonly object _syncRoot = new object();

        /// <summary>
        /// Приватный конструктор.
        /// </summary>
        private SingletonDoubleCheckLock()
        {
            
        }

        /// <summary>
        /// Объект SingletonDoubleCheckLock.
        /// </summary>
        public static SingletonDoubleCheckLock Instance
        {
            get
            {
                // Надо ли создавать объект, до того как создавать заимоисключающую блокировку?
                if (_instance == null)
                {
                    // Создание заимоисключающей блокировки.
                    lock (_syncRoot)
                    {
                        // Вторая проверка, вдруг уже кто-то до нас, кто раньше блокировал, уже вышел и создал.
                        if (_instance == null)
                        {
                            InstanceCount++;
                            _instance = new SingletonDoubleCheckLock();
                        }
                    }
                }
                return _instance;
            }
        }

        public void Test()
        {
            Console.WriteLine($"Кол-во созданных объектов {nameof(SingletonDoubleCheckLock)} - {InstanceCount}");
        }
    }
}