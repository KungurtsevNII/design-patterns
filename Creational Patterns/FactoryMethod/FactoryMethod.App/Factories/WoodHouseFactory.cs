using FactoryMethod.App.Products;

namespace FactoryMethod.App.Factories
{
    public class WoodHouseFactory : HouseFactory
    {
        public override HouseBase Build()
        {
            return new WoodHouse();
        }
    }
}