using ChainOfResponsibility.App.BankTransactionsHandlers;

namespace ChainOfResponsibility.App
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /// Создание объектов траназакций различных типов.
            /// Так же можно создать иерархию видов траназкций.
            var moneyTransaction = new BankTransaction(false, true, false, 1);
            var bankTransaction = new BankTransaction(true, false, false, 2);
            var payPalTransaction = new BankTransaction(false, false, true, 3);
            var secondMoneyTransaction = new BankTransaction(false, true, false, 4);
            
            // Задание цепочки ответсвенности.
            BaseTransactionHandler bankPaymentHandler = new BankTransactionHandler();
            BaseTransactionHandler moneyPaymentHnadler = new MoneyTransactionsHandler();
            BaseTransactionHandler paypalPaymentHandler = new PayPalTransactionsHandler();
            bankPaymentHandler.Next = paypalPaymentHandler;
            paypalPaymentHandler.Next = moneyPaymentHnadler;
            
            // Отправляем гулять по цепочке.
            bankPaymentHandler.Handle(moneyTransaction);
            bankPaymentHandler.Handle(bankTransaction);
            bankPaymentHandler.Handle(payPalTransaction);
            bankPaymentHandler.Handle(secondMoneyTransaction);
        }
    }
}