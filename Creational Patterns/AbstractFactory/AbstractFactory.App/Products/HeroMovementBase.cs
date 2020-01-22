namespace AbstractFactory.App.Products
{
    /// <summary>
    /// HeroMovementBase определяют интерфейс для классов, объекты которых будут создаваться в программе.
    /// Способ передвижения для героев.
    /// </summary>
    public abstract class HeroMovementBase
    {
        public abstract void Move();
    }
}