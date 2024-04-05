using System.ComponentModel.DataAnnotations;

namespace Sukuna.Common.Resources.Article;

public class ArticleResource // Les ressources sont les saisies utilisateurs
{
    [Key]
    public int ID { get; set; }
    public string Nom { get; set; }
    public string Description { get; set; }
    public int Prix { get; set; }
    public int QuantitéEnStock { get; set; }

    public ArticleResource() { }
}
