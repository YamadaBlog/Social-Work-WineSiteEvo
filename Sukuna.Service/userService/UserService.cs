using Sukuna.Business;
using Sukuna.Common.Models;
using Sukuna.Common.Resources.User;

namespace Sukuna.Service.userService;

public class UserService : IUserService
{
    public List<User> Users { get; set; }
    public UserService()
    {
        Users = new List<User>()
        {
            new User() { FirstName="cfd", Password="article1"},
            new User() { FirstName="cfd", Password="article2"},
            new User() { FirstName="cfd", Password="article3"},
        };
    }
    public string Add(UserResource userResource) // Les ressources sont les saisies utilisateurs
    {
        var existUser = Users.Find(x => x.Id == userResource.Id);
        if (existUser == null)
        {
            var user = new User()
            {
                Id = userResource.Id,
                FirstName = userResource.FirstName
            };
            Users.Add(user);
            return user.FirstName;
        }
        return "Already exist";
    }
    public User Get(int id)
    {
        var existUser = Users.Find(x => x.Id == id);
        if (existUser != null) return existUser;
        return null;
    }
    public string Update(UserResource userResource)
    {
        var existUser = Users.Find(x => x.Id == userResource.Id);
        if (existUser != null)
        {
            existUser.FirstName = userResource.FirstName;
            return existUser.FirstName;
        }
        return "No find";
    }
    public string Delete(UserResource userResource)
    {
        var article = Users.Find(x => x.Id == userResource.Id);
        if (article != null)
        {
            Users.Remove(article);
            return "Well deleted";
        }
        return "No existing";
    }
    public List<User> GetAll()
    {
        return Users;
    }
}
