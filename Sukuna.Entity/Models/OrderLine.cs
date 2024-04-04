using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sukuna.Common.Models
{
    public class OrderLine : Entity
    {
        public Article Article { get; set; }
        public ClientOrder ClientOrder { get; set; }
        public SupplierOrder SupplierOrder { get; set; }
        public Supplier Supplier { get; set; }
        public TvaType TVA { get; set; }
        public string Designation {  get; set; }
        public int Quantity { get; set; }
        public int Cost { get; set; } // Cout d'un article

        public OrderLine() { }
    }
}
