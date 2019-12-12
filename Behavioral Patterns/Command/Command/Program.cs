using System;

namespace Command
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Объект пульта - инициатора комманды.
            Pult pult = new Pult();
            // Принимающая сторона комманды.
            TV tv = new TV();
            // Устанавливаем комманду и кому она будет отправляться.
            pult.SetCommand(new TVOnCommand(tv));
            // Через нашу абстракцию пульт посылаем команды, нашей абстракции телевизору.
            pult.PressButton();
            pult.PressUndo();
         
            Console.Read();
        }
    }
}