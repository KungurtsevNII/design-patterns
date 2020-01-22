using FactoryMethod.App.Products;

namespace FactoryMethod.App.Factories
{
    public abstract class HouseFactory
    {
        public abstract HouseBase Build();
    }
}