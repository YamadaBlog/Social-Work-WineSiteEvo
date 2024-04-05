using Sukuna.Business;
using Sukuna.Common.Models;
using Sukuna.Common.Resources.User;

namespace Sukuna.Service.clientService;

public class ClientService
{
    public List<Client> Users { get; set; }
    public ClientService()
    {
        Users = new List<Client>()
        {
            new Client() { ID=1, Nom="article1"},
            new Client() { ID=2, Nom="article2"},
            new Client() { ID=3, Nom="article3"},
        };

    }
    public string Add(UserResource userResource) // Les ressources sont les saisies utilisateurs
    {
        var existUser = Users.Find(x => x.ID == userResource.ID);
        if (existUser == null)
        {
            var article = new Client()
            {
                ID = userResource.ID,
                Nom = userResource.Nom
            };
            Users.Add(article);
            return article.Nom;
        }
        return "Already exist";
    }
    public Client Get(int ID)
    {
        var existUser = Users.Find(x => x.ID == ID);
        if (existUser != null) return existUser;
        return null;
    }

    public string Delete(UserResource userResource)
    {
        var article = Users.Find(x => x.ID == userResource.ID);
        if (article != null)
        {
            Users.Remove(article);
            return "Well deleted";
        }
        return "No existing";
    }
    public List<Client> GetAll()
    {
        return Users;
    }
}
