using System;

namespace FactoryMethod.App.Products
{
    public class PanelHouse : HouseBase
    {
        public PanelHouse()
        {
            Console.WriteLine("Построен панельный домик.");
        }

        public override void Populate()
        {
            Console.WriteLine("Заселяем людишек в панельный дом.");
        }
    }
}