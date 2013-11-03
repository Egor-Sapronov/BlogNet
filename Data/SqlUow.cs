using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Contracts;
using Model;

namespace Data
{
    public class SqlUow:ISqlUow, IDisposable
    {
        public SqlUow(IRepositoryProvider repositoryProvider)
        {
            CreateDbContext();

            repositoryProvider.DbContext = DbContext;
            RepositoryProvider = repositoryProvider;
        }

        public void Commit()
        {
            DbContext.SaveChanges();
        }

        //public ITagRepository Tags { get { return GetRepo<ITagRepository>(); } }

        public IRepository<UserProfile> UserProfiles { get { return GetStandardRepo<UserProfile>(); } }


        protected void CreateDbContext()
        {
            DbContext = new BlogDbContext();

            // Do NOT enable proxied entities, else serialization fails
            DbContext.Configuration.ProxyCreationEnabled = false;

            // Load navigation properties explicitly (avoid serialization trouble)
            DbContext.Configuration.LazyLoadingEnabled = false;

            // Because Web API will perform validation, we don't need/want EF to do so
            DbContext.Configuration.ValidateOnSaveEnabled = false;

            //DbContext.Configuration.AutoDetectChangesEnabled = false;
            // We won't use this performance tweak because we don't need 
            // the extra performance and, when autodetect is false,
            // we'd have to be careful. We're not being that careful.
        }

        protected IRepositoryProvider RepositoryProvider { get; set; }

        private IRepository<T> GetStandardRepo<T>() where T : class
        {
            return RepositoryProvider.GetRepositoryForEntityType<T>();
        }
        private T GetRepo<T>() where T : class
        {
            return RepositoryProvider.GetRepository<T>();
        }

        private BlogDbContext DbContext { get; set; }

        #region IDisposable

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (DbContext != null)
                {
                    DbContext.Dispose();
                }
            }
        }

        #endregion
    }
}
