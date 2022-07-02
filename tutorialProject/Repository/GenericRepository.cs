﻿using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using tutorialProject.Data;
using tutorialProject.IRepository;

namespace tutorialProject.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        //we make the depedancy injection od the database injection and the class that we are created
        private readonly DatabaseContext _context;
        private readonly DbSet<T> _db;

        public GenericRepository (DatabaseContext context)
        {
            _context = context;
            _db = _context.Set<T>();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public Task<T> Get(Expression<Func<T, bool>> expression, List<string> includes = null)
        {
            throw new NotImplementedException();
        }

        public Task<IList<T>> GetAll(Expression<Func<T, bool>> expression = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, List<string> includes = null)
        {
            throw new NotImplementedException();
        }

        public Task Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public Task InsertRange(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
