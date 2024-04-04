using Sukuna.Common.Resources.Core;

namespace Sukuna.Common.Resources.Article;

public class ArticleResource: EntityResource // Les ressources sont les saisies utilisateurs
{
    public string Designation { get; set; }
    public string Author { get; set; }
}
