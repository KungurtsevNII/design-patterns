using System;
using AbstractFactory.App.Factories;

namespace AbstractFactory.App
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var elf = new Hero(new ElfFactory());
            var human = new Hero(new HumanWarriorFactory());
            
            Console.WriteLine("Война началась....");
            
            human.Hit();
            human.Run();
            elf.Hit();
            elf.Run();
        }
    }
}