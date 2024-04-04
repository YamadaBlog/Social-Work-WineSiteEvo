namespace Sukuna.Common.Models;

public class User : Entity
{
    public string LastName { get; set; }

    public string FirstName { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public bool IsAdmin { get; set; }

    public List<SupplierOrder> SupplierOrders { get; set; }

    public User()
    {
    }
}
