using Cibertec.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Cibertec.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private const int SUCCESS_TRANSACTION = 1;

        private readonly DbContext _dbContext;        

        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Delete(T entity)
        {
            _dbContext.Remove(entity);

            return _dbContext.SaveChanges() == SUCCESS_TRANSACTION;
        }

        public IEnumerable<T> GetAll()
        {
            return _dbContext.Set<T>();
        }

        public int Insert(T entity)
        {
            _dbContext.Add(entity);

            return _dbContext.SaveChanges();
        }

        public bool Update(T entity)
        {
            _dbContext.Update(entity);

            return _dbContext.SaveChanges() == SUCCESS_TRANSACTION;
        }

    }
}
