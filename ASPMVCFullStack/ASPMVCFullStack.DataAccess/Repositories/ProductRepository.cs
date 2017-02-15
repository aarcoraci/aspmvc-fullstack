using ASPMVCFullStack.DataAccess.Base;
using ASPMVCFullStack.Domain;
using ASPMVCFullStack.Domain.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPMVCFullStack.DataAccess.Repositories
{
    public class ProductRepository : BaseRepository<Product>
    {
        public ProductRepository(UnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        
        public Product GetByName(string name)
        {
            MyContext context = Context as MyContext;
            return context.Products.FirstOrDefault(n => n.Name.Equals(name));
        }
    }
}
