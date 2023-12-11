using Sukuna.Common.Models;
using Sukuna.Common.Resources.User;

namespace Sukuna.Business;

public interface IUserService
{
    public string Add(UserResource userResource);
    public string Update(UserResource userResource);
    public string Delete(UserResource userResource);
    public User Get(int id);

    public List<User> GetAll();
}
