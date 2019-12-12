﻿namespace Command
{
    /// <summary>
    /// Интерфейс, представляющий команду.
    /// Обычно определяет метод Execute() для выполнения действия,
    /// а также нередко включает метод Undo(),
    /// реализация которого должна заключаться в отмене действия команды.
    /// </summary>
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}