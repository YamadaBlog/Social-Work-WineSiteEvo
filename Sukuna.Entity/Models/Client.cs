namespace Sukuna.Common.Models;

public class Client : Entity
{
    public string LastName { get; set; } // Ce champ stocke le nom de famille du client.

    public string FirstName { get; set; } // Ce champ stocke le prénom du client.
    public string Password { get; set; } // Password du Client
    public string Email { get; set; } // Ce champ stocke l'adresse e-mail du client.
    public string Address { get; set; } // Ce champ sotck l'adresse de facturation, livraision et du bénificiaire

    public List<ClientOrder> ClientOrders { get; set; }
    public Client() 
    {
    }
}
