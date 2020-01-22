using System;

namespace Singleton.App
{
    public class SingletonLazy
    {
        /// <summary>
        /// Кол-во созданных объектов в сестеме.
        /// </summary>
        private static int _instanceCount;
        
        /// <summary>
        /// Lazy параметризированное SingletonLazy.
        /// Поле позволяет хранить инстанс потокобехопасно и лениво.
        /// </summary>
        private static readonly Lazy<SingletonLazy> _instance =
            new Lazy<SingletonLazy>(() =>
            {
                _instanceCount++;
                return new SingletonLazy();
            });
        
        /// <summary>
        /// Приватный конструктор,
        /// дабы в клиентском коде нельзы было породить объект.
        /// </summary>
        private SingletonLazy() {}
        
        /// <summary>
        /// Статическое поле,
        /// которое возвращает лениво и потокобезопасно объект Singletone.
        /// </summary>
        public static SingletonLazy Instance => _instance.Value;

        /// <summary>
        /// Метод проверки на кол-во созданных объектов в клиентском коде.
        /// </summary>
        public void Test()
        {
            Console.WriteLine($"Созданных объектов {nameof(SingletonLazy)} - {_instanceCount}");
        }
    }
}