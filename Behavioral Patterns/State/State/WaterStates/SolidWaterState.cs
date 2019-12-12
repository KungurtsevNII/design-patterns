using System;

namespace State.WaterStates
{
    /// <summary>
    /// Конкретное состояние воды - лед.
    /// Из этого состояния можно стать только жидкостью при нагреве.
    /// </summary>
    public class SolidWaterState : IWaterState
    {
        /// <summary>
        /// Нагрев льда
        /// </summary>
        /// <param name="water"></param>
        public void Heat(Water water)
        {
            Console.WriteLine("Превращаем лед в жидкость");
            water.State = new LiquidWaterState();
        }

        /// <summary>
        /// Заморозка льда
        /// </summary>
        /// <param name="water"></param>
        public void Frost(Water water)
        {
            Console.WriteLine("Продолжаем морозить лед.");
        }
    }
}