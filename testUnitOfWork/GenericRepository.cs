using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testUnitOfWork
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private AppDbContext DbContext;
        private DbSet<T> dbset;
        public GenericRepository(AppDbContext _DbContext)
        {
            DbContext = _DbContext;
            dbset = DbContext.Set<T>();
        }
        public List<T> GetAll()
        {
            return dbset.ToList();
        }
    }
}
