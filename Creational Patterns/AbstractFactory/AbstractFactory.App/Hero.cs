using AbstractFactory.App.Factories;
using AbstractFactory.App.Products;

namespace AbstractFactory.App
{
    /// <summary>
    /// Класс клиента Hero использует класс фабрики для создания объектов.
    /// При этом он использует исключительно абстрактный класс фабрики AbstractFactory и
    /// абстрактные классы продуктов AbstractProductA и AbstractProductB и никак не зависит от их конкретных реализаций
    /// </summary>
    public class Hero
    {
        private HeroWeaponBase _weapon;
        private HeroMovementBase _movement;

        public Hero(HeroFactory heroFactory)
        {
            _weapon = heroFactory.CreateWeaponBase();
            _movement = heroFactory.CreateMovement();
        }
        
        public void Run()
        {
            _movement.Move();
        }
        public void Hit()
        {
            _weapon.Hit();
        }
    }
}