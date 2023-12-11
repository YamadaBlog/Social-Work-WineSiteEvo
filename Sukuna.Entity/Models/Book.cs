namespace Sukuna.Common.Models;
public class Book : Entity // DAO DataObjectAccess
{
    public string Title { get; set; }
    public string Type { get; set; }
    public string Author { get; set; }

    public Book() { }
}
