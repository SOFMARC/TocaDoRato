using System;
using System.Collections.Generic;
using ProjLoja.Domain.Interfaces;
using ProjLoja.Infra.Data.Contexto;
using System.Linq;
using System.Data.Entity;

namespace ProjLoja.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected ProjModelContext Db = new ProjModelContext();

        public void Add(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);
            Db.SaveChanges();

        }

        public TEntity GetById(int id)
        {
            return Db.Set<TEntity>().Find(id);
        }


        public IEnumerable<TEntity> GetAll()
        {
            return Db.Set<TEntity>().ToList();
        }        

        public void Update(TEntity obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }

        IEnumerable<TEntity> IRepositoryBase<TEntity>.GetAll()
        {
            return Db.Set<TEntity>().ToList();
        }

        public void Remove(TEntity obj)
        {
            Db.Set<TEntity>().Remove(obj);
            Db.SaveChanges();
        }

        public void Dispose()
        {

        }
    }
}
