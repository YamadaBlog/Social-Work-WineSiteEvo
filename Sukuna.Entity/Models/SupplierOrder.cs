using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sukuna.Common.Models
{
    public class SupplierOrder : Entity
    {
        public DateOnly Date {  get; set; }
        public String State { get; set; }
        public int NumberArticle { get; set; }
        public int TotalHT {  get; set; }
        public int TotalTTC { get; set; }
        public int InvoiceNumber { get; set; } // Numéro de facture
        public bool Send { get; set; }
        public DateOnly SendOn { get; set; }
        public Supplier Supplier { get; set; }
        public User User { get; set; }
        public SupplierOrder() { }
    }
}
