using Sukuna.Business;
using Sukuna.Common.Models;
using Sukuna.Common.Resources.Role;

namespace Sukuna.Service.roleSerivce;

public class RoleService : IRoleService
{
    public List<Role> Roles { get; set; }
    public RoleService()
    {
        Roles = new List<Role>()
        {
            new Role() { Type="hello", Title="book1"},
            new Role() { Type="hello", Title="book2"},
            new Role() { Type="hello", Title="book3"},
        };

    }
    public string Add(RoleResource roleResource) // Les ressources sont les saisies utilisateurs
    {
        var existRole = Roles.Find(x => x.Type == roleResource.Type);
        if (existRole == null)
        {
            var book = new Role()
            {
                Type = roleResource.Type,
                Title = roleResource.Title
            };
            Roles.Add(book);
            return book.Title;
        }
        return "Already exist";
    }
    public Role Get(int id)
    {
        var existRole = Roles.Find(x => x.Id == id);
        if (existRole != null) return existRole;
        return null;
    }
    public string Update(RoleResource roleResource)
    {
        var existRole = Roles.Find(x => x.Type == roleResource.Type);
        if (existRole != null)
        {
            existRole.Title = roleResource.Type;
            return existRole.Title;
        }
        return "No find";
    }
    public string Delete(RoleResource roleResource)
    {
        var book = Roles.Find(x => x.Type == roleResource.Type);
        if (book != null)
        {
            Roles.Remove(book);
            return "Well deleted";
        }
        return "No existing";
    }
    public List<Role> GetAll()
    {
        return Roles;
    }
}
