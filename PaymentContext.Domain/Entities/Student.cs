
using paymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace paymentContext.Domain.Entities
{
    public class Student : Entity
    {
        private List<Subscription> _subscriptions;
        public Student(Name name, string lastName, Document document, string email)
        {
            Name = name;
            LastName = lastName;
            Document = document;
            Email = email;
            _subscriptions = new List<Subscription>();

            AddNotifications(name, document);

        }

        public Name Name { get; private set; }
        public string LastName { get; private set; }
        public Document Document{ get; private set; }
        public string Email { get; private set; }
        public Adress Adress { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray();} }
        public void AddSubscription(Subscription subscription)
        {
            // Se ja tiver uma assinatura, cancela

            //Cancela todas as outras assinaturas, e coloca esta
            //como principal
            foreach(var sub in Subscriptions){
                sub.Inactivate();
            }
            _subscriptions.Add(subscription);

        }
    }
}