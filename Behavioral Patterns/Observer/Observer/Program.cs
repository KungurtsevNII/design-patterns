using System;
using System.Collections;
using System.Collections.Generic;
using System.Reactive.Linq;
using Observer.ObserverStrongType;
using LogFileReader = Observer.ObserverByEvent.LogFileReader;
using LogFileReaderDelegate = Observer.ObserverByDelegate.LogFileReader;
using LogFileReaderStrongType = Observer.ObserverStrongType.LogFileReader;
using LogFileReaderRx = Observer.ObserverByRx.LogFileReader;

namespace Observer
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string fileName = "text.txt";

            #region Клиентский код паттерна Observer, через события.

            var subjectEvent = new LogFileReader(fileName);
            subjectEvent.OnNewLogEntry += (sender, eventArgs) =>
            {
                Console.WriteLine($"Проверял {sender} пришли новые {eventArgs.LogEntry}");
            };
            subjectEvent.OnNewLogEntry += (sender, eventArgs) =>
            {
                Console.WriteLine($"Проверял на наличие новых логов {sender}. Новые логи пришли следующие: {eventArgs.LogEntry}");
            };
            subjectEvent.CheckFile();

            #endregion
            
            #region Клиентский код паттерна Observer, через делегат.

            var subjectDelegate = new LogFileReaderDelegate(fileName, s =>
            {
                Console.WriteLine($"Пришли логи - {s}");
            });
           
            subjectDelegate.CheckFile();

            #endregion

            #region Клиентский код паттерна Observer, через интерфейсы.

            var subject = new LogFileReaderStrongType(fileName);

            subject.AddSaver(new LogFileSaver());
            subject.AddSaver(new LogDbSaver());
            
            subject.LogRead();
            
            #endregion

            #region Клиентский код паттерна Observer, через Rx.
            
            Console.WriteLine($"Логи с помощью Rx:");            
            var observer = new LogFileReaderRx(fileName);
            var log = observer.NewMessages.Subscribe(
                x => Console.WriteLine(x), 
                exception => Console.WriteLine(exception.Message), 
                () => Console.WriteLine("Всем подписчикам комплит, всем отписка."));

            /// <summary>
            /// Это должно быть внутри класса LogFileReader.
            /// Для упрощение вызов проиходит в клиентском коде.
            /// </summary>
            observer.CheckFile();
            // Освобождаем память. Отписываем всех.
            observer.Dispose();

            Console.WriteLine($"Остались ли подписчики - {observer.HasObservers}");
            
            #endregion
        }
    }
}