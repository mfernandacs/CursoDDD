using paymentContext.Domain.Entities;
using paymentContext.Domain.ValueObjects;
using Flunt.Notifications;

namespace paymentContext.Tests;

[TestClass]
public class StudentTests
{
    [TestMethod]
    public void AdicionarAssinatura()
    {
        var name = new Name("Teste", "Teste");
        foreach(var not in name.Notifications){
            
        }

    }
}