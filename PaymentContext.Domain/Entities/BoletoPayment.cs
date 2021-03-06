using paymentContext.Domain.ValueObjects;

namespace paymentContext.Domain.Entities
{
    public class BoletoPayment : Payment
    {
        public BoletoPayment(string barCode, 
                            string boletoNumber,
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
            BarCode = barCode;
            BoletoNumber = boletoNumber;
        }

        public string BarCode  { get; private set; }
        public string BoletoNumber { get; private set; }
    }
}