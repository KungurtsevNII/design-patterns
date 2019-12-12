namespace Command
{
    /// <summary>
    /// ConcreteCommand: конкретная реализация команды,
    /// реализует метод Execute(), в котором вызывается определенный метод, определенный в классе Receiver.
    /// Команда на включение телевизора.
    /// </summary>
    public class TVOnCommand : ICommand
    {
        private TV _tv;

        public TVOnCommand(TV tv)
        {
            _tv = tv;
        }

        public void Execute()
        {
            _tv.On();
        }

        public void Undo()
        {
            _tv.Off();
        }
    }
}