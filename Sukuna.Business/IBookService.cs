using Sukuna.Common.Models;
using Sukuna.Common.Resources.Article;

namespace Sukuna.Business;

// Besoin de boook resources from common bcs it takes the the parameters reuse in serive 

public interface IArticleService
{
    public string Add(ArticleResource articleResource);
    public string Update(ArticleResource articleResource);
    public string Delete(ArticleResource articleResource);
    public Article Get(int id);
    public string Create(ArticleResource articleResource);

    public List<Article> GetAll();   
}