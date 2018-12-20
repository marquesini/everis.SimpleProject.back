﻿using everis.SimpleProject.Domain.Models;
using everis.SimpleProject.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace everis.SimpleProject.Data.EF.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T>
        where T:Entity
    {
        private readonly DbSet<T> _dbSet;
        private readonly DbContext _dbContext;

        public GenericRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }


        public T Adicionar(T obj)
        {
            _dbSet.Add(obj);
            return obj;
        }

        public T Atualizar(T obj)
        {
            var entity = _dbContext.Set<T>().Single(x => x.Id == obj.Id);

            _dbContext.Entry(entity).State = EntityState.Detached;
            _dbContext.Entry(entity).State = EntityState.Detached;
            
            _dbContext.Set<T>().Update(obj);

            return obj;
        }

        public IQueryable<T> BuscarPor(Expression<Func<T, bool>> predicate,
            params Expression<Func<T, object>>[] includes)
        {
            var currentSet = _dbContext.Set<T>();
            IQueryable<T> query = currentSet;
            foreach (var inc in includes)
                query = query.Include(inc);
            return query.Where(predicate);
        }

        public T ObterPorId(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public IEnumerable<T> ObterTodos()
        {
            return _dbContext.Set<T>().ToList();
        }

        public void Remover(int id)
        {
            _dbContext.Set<T>().Remove(ObterPorId(id));
            _dbContext.SaveChanges();
        }

        public int SaveChanges()
        {
            return _dbContext.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}