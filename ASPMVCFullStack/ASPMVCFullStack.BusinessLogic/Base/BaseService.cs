using ASPMVCFullStack.DataAccess;
using ASPMVCFullStack.DataAccess.Base;
using ASPMVCFullStack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ASPMVCFullStack.BusinessLogic.Base
{
    public abstract class BaseService<TEntity> : IDisposable where TEntity : BaseEntity
    {
        public UnitOfWork UnitOfWork { get; set; }
        public BaseRepository<TEntity> Repository { get; set; }

        public BaseService(UnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork; 
        }

        public void Dispose()
        {
            if (UnitOfWork != null)
                UnitOfWork.Dispose();
            GC.SuppressFinalize(this);
        }

        #region public methods

        public virtual void SaveChanges()
        {
            Repository.SaveChanges();
        } 

        public virtual IEnumerable<TEntity> GetAll()
        {
            return Repository.GetAll();
        }

        public virtual IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return Repository.Find(predicate);
        }

        public virtual int Count()
        {
            return Repository.Count();
        }

        public virtual bool Any(Expression<Func<TEntity, bool>> predicate)
        {
            return Repository.Any(predicate);
        }

        public virtual TEntity GetById(Guid id)
        {
            return Repository.GetById(id);
        }

        public virtual void Add(TEntity entity)
        {
            Repository.Add(entity);
        }

        public virtual void Delete(TEntity entity)
        {
            Repository.Delete(entity);
        }

        #endregion
    }
}
