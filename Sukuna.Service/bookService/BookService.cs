using Sukuna.Business;
using Sukuna.Common.Models;
using Sukuna.Common.Resources.Book;
using Sukuna.DataAccess;

namespace Sukuna.Service.bookService;

public class BookService: IBookService // Il est question d'implementer et pas d'héritage CELA FONCtIONNE AVEC PROGM.CS
    // remettre le bon nom des fontions 
{
    private readonly BookDbContext _context;
    public List<Book> Books { get; set; }
    public BookService()
    {
        Books = new List<Book>()
        {
            new Book() { Id=1, Title="book1"},
            new Book() { Id=2, Title="book2"},
            new Book() { Id=3, Title="book3"},
        };

    }

    public bool ExistBook(BookResource bookRessources)
    {
        var existBook = Books.Find(x => x.Id == bookRessources.Id);
        if (existBook == null)
        {
            return true;
        }
        return false;
    }
    // Fanny code
    public string Add(BookResource bookResource)
    {
        if (ExistBook(bookResource))
        {
            var book = new Book()
            {
                Id = bookResource.Id,
                Title = bookResource.Title,
            };
            /// var a = _context.Books.ToList();
            /// /// var a = _context.Books.Where( x => x.Id == bookRessource.Id);
            Books.Add(book);
            return book.Title;
        }
        return "already exist";
    }
    public string Create(BookResource bookResource) // Les ressources sont les saisies utilisateurs
    {
        var existBook = Books.Find(x => x.Id == bookResource.Id);
        if (existBook == null)
        {
            var book = new Book()
            {
                Id = bookResource.Id,
                Title = bookResource.Title
            };
            Books.Add(book);
            return book.Title;
        }
        return "Already exist";
    }
    public Book Get(int id)
    {
        var existBook = Books.Find(x => x.Id == id);
        if (existBook != null) return existBook;
        return null;
    }
    public string Update(BookResource bookResource)
    {
        var existBook = Books.Find(x => x.Id == bookResource.Id);
        if (existBook != null)
        {
            existBook.Title = bookResource.Title;
            return existBook.Title;
        }
        return "No find";
    }
    public string Delete(BookResource bookResource)
    {
        var book = Books.Find(x => x.Id == bookResource.Id);
        if (book != null)
        {
            Books.Remove(book);
            return "Well deleted";
        }
        return "No existing";
    }
    public List<Book> GetAll()
    {
        return Books;
    }
}
