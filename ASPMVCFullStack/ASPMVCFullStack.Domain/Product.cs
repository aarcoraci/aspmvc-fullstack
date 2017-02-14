using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPMVCFullStack.Domain
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public virtual Category Category { get; set; }
    }
}
