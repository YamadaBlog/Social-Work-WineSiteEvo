namespace Sukuna.Common.Models;

public class User : Entity
{
    public string Name { get; set; }

    public string FirstName { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string ConfirmPassword { get; set; }
    public List<UserRole> UserRoles { get; set; } // tjrs initialiser une liste pour eviter de sretouver avec des references null 

    public User()
    {
        UserRoles = new List<UserRole>();
    }
}
