using PaymentContext.Shared.ValueObjects;
using Flunt.Validations;

namespace paymentContext.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public Email(string adress)
        {
            Adress = adress;

            AddNotifications(new Contract()
                .Requires()
                .IsEmail(Adress, "email adress", "email invalido") 

            )
        }

        public string Adress { get; private set; }
    }
}