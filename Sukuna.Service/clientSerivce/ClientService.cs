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
            new Role() { Type="hello", Designation="article1"},
            new Role() { Type="hello", Designation="article2"},
            new Role() { Type="hello", Designation="article3"},
        };

    }
    public string Add(RoleResource roleResource) // Les ressources sont les saisies utilisateurs
    {
        var existRole = Roles.Find(x => x.Type == roleResource.Type);
        if (existRole == null)
        {
            var article = new Role()
            {
                Type = roleResource.Type,
                Designation = roleResource.Designation
            };
            Roles.Add(article);
            return article.Designation;
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
            existRole.Designation = roleResource.Type;
            return existRole.Designation;
        }
        return "No find";
    }
    public string Delete(RoleResource roleResource)
    {
        var article = Roles.Find(x => x.Type == roleResource.Type);
        if (article != null)
        {
            Roles.Remove(article);
            return "Well deleted";
        }
        return "No existing";
    }
    public List<Role> GetAll()
    {
        return Roles;
    }
}
