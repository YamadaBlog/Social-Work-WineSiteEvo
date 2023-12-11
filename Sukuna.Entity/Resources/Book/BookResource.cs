using Sukuna.Common.Resources.Core;

namespace Sukuna.Common.Resources.Book;

public class BookResource: EntityResource // Les ressources sont les saisies utilisateurs
{
    public string Title { get; set; }
    public string Author { get; set; }
}
