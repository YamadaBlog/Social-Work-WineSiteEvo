using Sukuna.Common.Models;
using Sukuna.Common.Resources.Book;

namespace Sukuna.Business;

// Besoin de boook resources from common bcs it takes the the parameters reuse in serive 

public interface IBookService
{
    public string Add(BookResource bookResource);
    public string Update(BookResource bookResource);
    public string Delete(BookResource bookResource);
    public Book Get(int id);
    public string Create(BookResource bookResource);

    public List<Book> GetAll();   
}