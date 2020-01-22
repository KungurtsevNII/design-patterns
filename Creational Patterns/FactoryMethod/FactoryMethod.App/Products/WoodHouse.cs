using System;

namespace FactoryMethod.App.Products
{
    public class WoodHouse : HouseBase
    {
        public WoodHouse()
        {
            Console.WriteLine("Деревяный дом построен.");
        }

        public override void Populate()
        {
            Console.WriteLine("Заселение дровосеков в деревяный дом.");
        }
    }
}