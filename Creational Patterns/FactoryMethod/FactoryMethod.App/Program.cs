using System.Collections.Generic;
using FactoryMethod.App.Factories;
using FactoryMethod.App.Products;

namespace FactoryMethod.App
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<HouseBase> district = new List<HouseBase>(); 
            var woodHouseFactory = new WoodHouseFactory();
            var panelHouseFactory = new PanelHouseFactory();
            
            district.Add(woodHouseFactory.Build());
            district.Add(woodHouseFactory.Build());
            district.Add(panelHouseFactory.Build());
            district.Add(panelHouseFactory.Build());
            district.Add(panelHouseFactory.Build());
            
            district.ForEach(x => x.Populate());
        }
    }
}