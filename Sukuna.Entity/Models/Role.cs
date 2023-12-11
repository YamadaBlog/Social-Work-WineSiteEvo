namespace Sukuna.Common.Models;

public class Role : Entity
{
    public string Title { get; set; }

    public string Type { get; set; }
    public List<UserRole> UserRoles { get; set; }
    public Role() 
    {
        UserRoles = new List<UserRole>();
    }
}
