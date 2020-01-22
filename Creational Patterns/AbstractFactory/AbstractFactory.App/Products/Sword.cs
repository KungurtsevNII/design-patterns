using System;

namespace AbstractFactory.App.Products
{
    /// <summary>
    /// Одиз из конкретных продуктов семейства HeroWeaponBase - меч.
    /// </summary>
    public class Sword : HeroWeaponBase
    {
        public override void Hit()
        {
            Console.WriteLine("Удар мечом по башке.");
        }
    }
}