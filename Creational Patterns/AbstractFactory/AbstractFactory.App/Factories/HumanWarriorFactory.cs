using AbstractFactory.App.Products;

namespace AbstractFactory.App.Factories
{
    public class HumanWarriorFactory : HeroFactory
    {
        public override HeroMovementBase CreateMovement()
        {
            return new RunMovement();
        }

        public override HeroWeaponBase CreateWeaponBase()
        {
            return new Sword();
        }
    }
}