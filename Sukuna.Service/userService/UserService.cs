﻿using Sukuna.Business;
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
            new User() { Nom="cfd", MotDePasseHashe="article1"},
            new User() { Nom ="cfd", MotDePasseHashe="article2"},
            new User() { Nom ="cfd", MotDePasseHashe="article3"},
        };
    }
    public string Add(UserResource userResource) // Les ressources sont les saisies utilisateurs
    {
        var existUser = Users.Find(x => x.ID == userResource.ID);
        if (existUser == null)
        {
            var user = new User()
            {
                ID = userResource.ID,
                Nom = userResource.Nom
            };

            Users.Add(user);
            return user.Nom;
        }
        return "Already exist";
    }
    public User Get(int id)
    {
        var existUser = Users.Find(x => x.ID == id);
        if (existUser != null) return existUser;
        return null;
    }
    public string Update(UserResource userResource)
    {
        var existUser = Users.Find(x => x.ID == userResource.ID);
        if (existUser != null)
        {
            existUser.Nom = userResource.Nom;
            return existUser.Nom;
        }
        return "No find";
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
    public List<User> GetAll()
    {
        return Users;
    }
}
