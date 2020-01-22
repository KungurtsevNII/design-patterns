using System;

namespace AbstractFactory.App.Products
{
    /// <summary>
    /// Одиз из конкретных продуктов семейства HeroMovementBase - бег.
    /// </summary>
    public class RunMovement : HeroMovementBase
    {
        public override void Move()
        {
            Console.WriteLine("Бежим на ноге, крыльев нет(((");
        }
    }
}