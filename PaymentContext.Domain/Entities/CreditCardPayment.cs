using paymentContext.Domain.ValueObjects;

namespace paymentContext.Domain.Entities
{
 
    public class CreditCardPayment : Payment
    {
        public CreditCardPayment(string cardHikderName, 
                                string cardNumber, 
                                string lastTransactionNumber, 
                                DateTime paidDate, 
                                DateTime expireDate, 
                                decimal total, 
                                decimal totalPaid, 
                                Document document, 
                                string payer, 
                                Adress adress, 
                                Email email) : base (paidDate, 
                                                      expireDate, 
                                                      total, 
                                                      totalPaid, 
                                                      document, 
                                                      payer, 
                                                      adress, 
                                                      email)
        {
            CardHikderName = cardHikderName;
            CardNumber = cardNumber;
            LastTransactionNumber = lastTransactionNumber;
        }

        public string CardHikderName { get; private set; }
        public string CardNumber { get; private set; }
        public string LastTransactionNumber { get; private set; }
    }

}