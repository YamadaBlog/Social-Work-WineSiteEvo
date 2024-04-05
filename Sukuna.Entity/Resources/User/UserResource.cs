using Sukuna.Common.Models;

namespace Sukuna.Common.Resources.User;

public class UserResource
{
    public int ID { get; set; }
    public string Nom { get; set; }
    public string Prénom { get; set; }
    public string Email { get; set; }
    public string MotDePasseHashé { get; set; }
    public string Rôle { get; set; }

    public UserResource() { }
}
