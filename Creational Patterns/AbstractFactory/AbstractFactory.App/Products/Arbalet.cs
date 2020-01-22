using System;

namespace AbstractFactory.App.Products
{
    /// <summary>
    /// Одиз из конкретных продуктов семейства HeroWeaponBase - арбалет.
    /// </summary>
    public class Arbalet : HeroWeaponBase
    {
        public override void Hit()
        {
            Console.WriteLine("Стреляем из арбалета.");
        }
    }
}