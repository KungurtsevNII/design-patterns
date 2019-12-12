using State.WaterStates;

namespace State
{
    /// <summary>
    /// Контекст (Water) делегирует операции по переходу между состояниями объектам
    /// State, что позволяет перейти из состояния ConcreteState1 в новое состояние ConcreteState2
    /// </summary>
    public class Water
    {
        public IWaterState State { get; set; }

        public Water(IWaterState state)
        {
            State = state;
        }

        public void Heat()
        {
            State.Heat(this);
        }

        public void Frost()
        {
            State.Frost(this);
        }
    }
}