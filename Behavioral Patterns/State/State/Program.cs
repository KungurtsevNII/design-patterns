using System;
using State.WaterStates;

namespace State
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Water water = new Water(new LiquidWaterState());
            
            water.Heat();
            water.Frost();
            water.Frost();
            water.Heat();
            water.Heat();
            water.Heat();
 
            Console.Read();
        }
    }
}