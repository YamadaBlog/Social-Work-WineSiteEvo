using Sukuna.Common.Models;
using Sukuna.Common.Resources.Role;

namespace Sukuna.Business;

public interface IRoleService
{
    public string Add(RoleResource roleResource);
    public string Update(RoleResource roleResource);
    public string Delete(RoleResource roleResource);
    public Role Get( int id);

    public List<Role> GetAll();
}
