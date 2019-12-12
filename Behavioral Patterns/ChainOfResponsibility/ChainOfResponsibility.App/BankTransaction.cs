namespace ChainOfResponsibility.App
{
    public class BankTransaction
    {
        public uint Id { get; }
        
        // банковские переводы
        public bool BankTransfer { get; }
        
        // денежные переводы - WesternUnion, Unistream
        public bool MoneyTransfer { get; }
        
        // перевод через PayPal
        public bool PayPalTransfer { get; }
        
        public BankTransaction(bool bt, bool mt, bool ppt, uint id)
        {
            BankTransfer = bt;
            MoneyTransfer = mt;
            PayPalTransfer = ppt;
            Id = id;
        }
    }
}