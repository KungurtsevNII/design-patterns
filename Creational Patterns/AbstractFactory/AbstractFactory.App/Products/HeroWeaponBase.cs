namespace AbstractFactory.App.Products
{
    /// <summary>
    /// HeroWeaponBase определяют интерфейс для классов, объекты которых будут создаваться в программе.
    /// Оружие для героев.
    /// </summary>
    public abstract class HeroWeaponBase
    {
        public abstract void Hit();
    }
}