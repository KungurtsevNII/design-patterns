using AbstractFactory.App.Products;

namespace AbstractFactory.App.Factories
{
    public class ElfFactory : HeroFactory
    {
        public override HeroMovementBase CreateMovement()
        {
            return new FlyMovement();
        }

        public override HeroWeaponBase CreateWeaponBase()
        {
            return new Arbalet();
        }
    }
}