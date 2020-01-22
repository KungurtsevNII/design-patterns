using AbstractFactory.App.Products;

namespace AbstractFactory.App.Factories
{
    /// <summary>
    /// Абстрактный класс фабрики HeroFactory, определяет методы для создания объектов.
    /// Причем методы возвращают абстрактные продукты, а не их конкретные реализации.
    /// </summary>
    public abstract class HeroFactory
    {
        public abstract HeroMovementBase CreateMovement();
        public abstract HeroWeaponBase CreateWeaponBase();
    }
}