using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sukuna.Common.Models
{
    public class TvaType : Entity
    {
        public String Name { get; set; }
        public float TVAValue { get; set; }
        public List<Article> Articles { get; set; }
        public TvaType() { }
    }
}
