namespace ChainOfResponsibility.App.BankTransactionsHandlers
{
    /// <summary>
    /// Handler:
    /// Определяет интерфейс для обработки запроса.
    /// Также может определять ссылку на следующий обработчик запроса
    /// </summary>
    public abstract class BaseTransactionHandler
    {
        public BaseTransactionHandler Next { get; set; }

        public abstract void Handle(BankTransaction transaction);
    }
}