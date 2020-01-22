using System;

namespace AbstractFactory.App.Products
{
    /// <summary>
    /// Одиз из конкретных продуктов семейства HeroMovementBase - полет.
    /// </summary>
    public class FlyMovement : HeroMovementBase
    {
        public override void Move()
        {
            Console.WriteLine("Летим на крыльях ночи.");
        }
    }
}