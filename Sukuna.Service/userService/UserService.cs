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
            new User() { Name="cfd", Password="book1"},
            new User() { Name="cfd", Password="book2"},
            new User() { Name="cfd", Password="book3"},
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
                Name = userResource.Name
            };
            Users.Add(user);
            return user.Name;
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
            existUser.Name = userResource.Name;
            return existUser.Name;
        }
        return "No find";
    }
    public string Delete(UserResource userResource)
    {
        var book = Users.Find(x => x.Id == userResource.Id);
        if (book != null)
        {
            Users.Remove(book);
            return "Well deleted";
        }
        return "No existing";
    }
    public List<User> GetAll()
    {
        return Users;
    }
}
