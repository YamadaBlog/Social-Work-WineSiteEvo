namespace Sukuna.Common.Models;
public class Article : Entity // DAO DataObjectAccess
{
    public string Designation { get; set; } // Désignation ou nom de l'article.
    public float Price { get; set; } // Prix de l'article 
    public int stockAmount { get; set; } // Quantité de stock de l'article.
    public string stockByClientOrder { get; set; } // Quantité de cet article commandée par les clients
    public string stockBySupplierOrder { get; set; } // Quantité de cet article commandée aux fournisseurs
    public string stockMin { get; set; } // Quantité minimale de stock souhaitée pour cet article.
    public Supplier Supplier { get; set; }
    public TvaType TvaValue { get; set; }


    public Article() { }
}
