using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sukuna.Common.Models
{
    public class Supplier : Entity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public List<Article> Articles { get; set; } 
        public Supplier()
        {
        }
    }
}
