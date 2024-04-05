using Sukuna.Business;
using Sukuna.Common.Models;
using Sukuna.Common.Resources.Article;

namespace Sukuna.Service.articleService;

public class ArticleService: IArticleService // Il est question d'implementer et pas d'héritage CELA FONCtIONNE AVEC PROGM.CS
    // remettre le bon nom des fontions 
{
    public List<Article> Articles { get; set; }
    public ArticleService()
    {
        Articles = new List<Article>()
        {
            new Article() { ID=1, Nom="article1"},
            new Article() { ID=2, Nom="article2"},
            new Article() { ID=3, Nom="article3"},
        };

    }

    public bool ExistArticle(ArticleResource articleRessources)
    {
        var existArticle = Articles.Find(x => x.ID == articleRessources.ID);
        if (existArticle == null)
        {
            return true;
        }
        return false;
    }
    // Fanny code
    public string Add(ArticleResource articleResource)
    {
        if (ExistArticle(articleResource))
        {
            var article = new Article()
            {
                ID = articleResource.ID,
                Nom = articleResource.Nom,
            };
            /// var a = _context.Articles.ToList();
            /// /// var a = _context.Articles.Where( x => x.Id == articleRessource.Id);
            Articles.Add(article);
            return article.Nom;
        }
        return "already exist";
    }
    public string Create(ArticleResource articleResource) // Les ressources sont les saisies utilisateurs
    {
        var existArticle = Articles.Find(x => x.ID == articleResource.ID);
        if (existArticle == null)
        {
            var article = new Article()
            {
                ID = articleResource.ID,
                Nom = articleResource.Nom
            };
            Articles.Add(article);
            return article.Nom;
        }
        return "Already exist";
    }
    public Article Get(int id)
    {
        var existArticle = Articles.Find(x => x.ID == id);
        if (existArticle != null) return existArticle;
        return null;
    }
    public string Update(ArticleResource articleResource)
    {
        var existArticle = Articles.Find(x => x.ID == articleResource.ID);
        if (existArticle != null)
        {
            existArticle.Nom = articleResource.Nom;
            return existArticle.Nom;
        }
        return "No find";
    }
    public string Delete(ArticleResource articleResource)
    {
        var article = Articles.Find(x => x.ID == articleResource.ID);
        if (article != null)
        {
            Articles.Remove(article);
            return "Well deleted";
        }
        return "No existing";
    }
    public List<Article> GetAll()
    {
        return Articles;
    }
}
