using paymentContext.Domain.ValueObjects;

namespace paymentContext.Domain.Entities
{
    public class PayPalPayment : Payment
    {
        public PayPalPayment(string transctionCode,
                            DateTime paidDate, 
                            DateTime expireDate, 
                            decimal total, 
                            decimal totalPaid, 
                            Document document, 
                            string payer, 
                            Adress adress, 
                            Email email) : base(paidDate,
                                                 expireDate,
                                                 total,
                                                 totalPaid,
                                                 document,
                                                 payer,
                                                 adress, 
                                                 email)
        {
            TransctionCode = transctionCode;
        }

        public string TransctionCode { get; private set; }
    }
}