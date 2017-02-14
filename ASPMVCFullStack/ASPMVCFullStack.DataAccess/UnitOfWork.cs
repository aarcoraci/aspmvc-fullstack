using ASPMVCFullStack.Domain.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPMVCFullStack.DataAccess
{
    public class UnitOfWork : IDisposable
    {
        public DbContext Context { get; set; }
        
        public UnitOfWork()
        {
            Context = MyContext.Create();
        }

        public void Dispose()
        {
            if (Context != null)
            {
                Context.Dispose();
                Context = null;
            }
            GC.SuppressFinalize(this);
        }
    }
}
