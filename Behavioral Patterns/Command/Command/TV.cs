using System;

namespace Command
{
    /// <summary>
    /// Receiver: получатель команды.
    /// Определяет действия, которые должны выполняться в результате запроса.
    /// </summary>
    public class TV
    {
        public void On()
        {
            Console.WriteLine("Телевизор включен!");
        }
 
        public void Off()
        {
            Console.WriteLine("Телевизор выключен...");
        }
    }
}