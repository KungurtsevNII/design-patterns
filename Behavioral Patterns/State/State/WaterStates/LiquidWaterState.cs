using System;

namespace State.WaterStates
{
    /// <summary>
    /// Конкретное состояние воды - жидкость.
    /// Из этого состояния можно стоть паром и льдом.
    /// </summary>
    public class LiquidWaterState : IWaterState
    {
        /// <summary>
        /// Нагрев жидкости
        /// </summary>
        /// <param name="water"></param>
        public void Heat(Water water)
        {
            Console.WriteLine("Превращаем жидкость в пар.");
            water.State = new GasWaterState();
        }

        /// <summary>
        /// Заморозка жидкости
        /// </summary>
        /// <param name="water"></param>
        public void Frost(Water water)
        {
            Console.WriteLine("Превращаем жидкость в лед.");
            water.State = new SolidWaterState();
        }
    }
}