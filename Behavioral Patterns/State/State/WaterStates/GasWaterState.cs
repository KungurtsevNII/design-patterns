using System;

namespace State.WaterStates
{
    /// <summary>
    /// Конкретное состояние воды - пар.
    /// Из этого состояния можно попать только в жидкость при заморозке.
    /// </summary>
    public class GasWaterState : IWaterState
    {
        /// <summary>
        /// Нагрев пара
        /// </summary>
        /// <param name="water"></param>
        public void Heat(Water water)
        {
            Console.WriteLine("Продолжаем греть пар.");
        }

        /// <summary>
        /// Заморозка пара
        /// </summary>
        /// <param name="water"></param>
        public void Frost(Water water)
        {
            Console.WriteLine("Превращаем пар в жидкость.");
            water.State = new LiquidWaterState();
        }
    }
}