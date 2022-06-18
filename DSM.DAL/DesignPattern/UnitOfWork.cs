using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

using System;
using System.Threading.Tasks;

namespace DSM.DAL
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : DbContext
    {
        #region Fields

        bool _IsDisposed = false;

        public UnitOfWork(T DSMDBContext) => this.DSMREPO = DSMDBContext;

        #endregion

        #region Props

        public T DSMREPO { get; }
        public IDbContextTransaction DbContextTransaction { get; set; }

        public bool IsDisposed { get => _IsDisposed; }

        public DSMDBContext DSMDBContext => throw new NotImplementedException();

        #endregion

        #region Methods

        public virtual void Commit() => DSMREPO.Database.CurrentTransaction.Commit();

        public bool SaveChanges()
        {
            try
            {
                return DSMREPO.SaveChanges() >= 0;
            }
            catch (Exception ex)
            {
                _ = ex.Message;
                return false;
            }
        }

        public async Task<bool> SaveChangesAsync()
        {
            try
            {
                return (await DSMREPO.SaveChangesAsync()) > 0;
            }
            catch
            {
                return false;
            }
        }

        public void Dispose()
        {
            DSMREPO.Dispose();
            _IsDisposed = true;
        }
        #endregion
    }

}
