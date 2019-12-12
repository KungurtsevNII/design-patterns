using System;

namespace ChainOfResponsibility.App.BankTransactionsHandlers
{
    /// <summary>
    /// ConcreteHandler2:
    /// Конкретные обработчики, которые реализуют функционал для обработки запроса.
    /// При невозможности обработки и наличия ссылки на следующий обработчик, передают запрос этому обработчику.
    /// </summary>
    public class BankTransactionHandler : BaseTransactionHandler
    {
        /// <summary>
        /// Обработка банковского перевода.
        /// </summary>
        /// <param name="transaction">
        /// Банковская транзакция с пометкой типа.
        /// </param>
        public override void Handle(BankTransaction transaction)
        {
            // Может ли данное звено цепочки обработать.
            if (transaction.BankTransfer)
            {
                Console.WriteLine($"Выполняем банковский перевод, id {transaction.Id}");
            }
            
            // Если цепочка не закончена, передаем транзакцию дальше.
            Next?.Handle(transaction);
        }
    }
}