using FactoryMethod.App.Products;

namespace FactoryMethod.App.Factories
{
    public class PanelHouseFactory : HouseFactory
    {
        public override HouseBase Build()
        {
            return new PanelHouse();
        }
    }
}