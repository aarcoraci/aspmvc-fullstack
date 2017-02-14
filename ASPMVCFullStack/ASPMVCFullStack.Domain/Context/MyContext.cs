using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPMVCFullStack.Domain.Context
{
    public class MyContext : DbContext
    { 
        public static DbContext Create()
        {
            return new MyContext();
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
