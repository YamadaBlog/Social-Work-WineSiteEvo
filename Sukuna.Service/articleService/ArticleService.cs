using Sukuna.Business;
using Sukuna.Common.Models;
using Sukuna.Common.Resources.Article;
using Sukuna.DataAccess;

namespace Sukuna.Service.articleService;

public class ArticleService: IArticleService // Il est question d'implementer et pas d'héritage CELA FONCtIONNE AVEC PROGM.CS
    // remettre le bon nom des fontions 
{
    private readonly ArticleDbContext _context;
    public List<Article> Articles { get; set; }
    public ArticleService()
    {
        Articles = new List<Article>()
        {
            new Article() { Id=1, Designation="article1"},
            new Article() { Id=2, Designation="article2"},
            new Article() { Id=3, Designation="article3"},
        };

    }

    public bool ExistArticle(ArticleResource articleRessources)
    {
        var existArticle = Articles.Find(x => x.Id == articleRessources.Id);
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
                Id = articleResource.Id,
                Designation = articleResource.Designation,
            };
            /// var a = _context.Articles.ToList();
            /// /// var a = _context.Articles.Where( x => x.Id == articleRessource.Id);
            Articles.Add(article);
            return article.Designation;
        }
        return "already exist";
    }
    public string Create(ArticleResource articleResource) // Les ressources sont les saisies utilisateurs
    {
        var existArticle = Articles.Find(x => x.Id == articleResource.Id);
        if (existArticle == null)
        {
            var article = new Article()
            {
                Id = articleResource.Id,
                Designation = articleResource.Designation
            };
            Articles.Add(article);
            return article.Designation;
        }
        return "Already exist";
    }
    public Article Get(int id)
    {
        var existArticle = Articles.Find(x => x.Id == id);
        if (existArticle != null) return existArticle;
        return null;
    }
    public string Update(ArticleResource articleResource)
    {
        var existArticle = Articles.Find(x => x.Id == articleResource.Id);
        if (existArticle != null)
        {
            existArticle.Designation = articleResource.Designation;
            return existArticle.Designation;
        }
        return "No find";
    }
    public string Delete(ArticleResource articleResource)
    {
        var article = Articles.Find(x => x.Id == articleResource.Id);
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
