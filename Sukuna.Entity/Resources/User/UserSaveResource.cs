using Sukuna.Common.Resources.Role;

namespace Sukuna.Common.Resources.User;

public class UserSaveResource
{
    public string Name { get; set; }

    public string FirstName { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }

    public List<RoleResource> Roles;

    public UserSaveResource()
    {
        Roles = new List<RoleResource>();
    }
}
