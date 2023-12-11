using Sukuna.Common.Models;
using Sukuna.Common.Resources.Core;
using Sukuna.Common.Resources.Role;

namespace Sukuna.Common.Resources.User;

public class UserResource : EntityResource
{
    public string Name { get; set; }
    public string FirstName { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }

    public List<RoleResource> Roles;

    public UserResource()
    {
        Roles = new List<RoleResource>();
    }
}
