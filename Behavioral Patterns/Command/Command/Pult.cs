namespace Command
{
    /// <summary>
    /// Invoker: инициатор команды - вызывает команду для выполнения определенного запроса
    /// </summary>
    public class Pult
    {
        ICommand command;
 
        public Pult() { }
 
        public void SetCommand(ICommand com)
        {
            command = com;
        }
 
        public void PressButton()
        {
            command.Execute();
        }
        public void PressUndo()
        {
            command.Undo();
        }
    }
}