using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testUnitOfWork
{
    public class UnitOfWork : IDisposable
    {
        private AppDbContext context = new AppDbContext();
        private GenericRepository<Log> _genericRepository;


        public GenericRepository<Log> GenericRepository
        {
            get
            {
                if (_genericRepository == null)
                {
                    _genericRepository = new GenericRepository<Log>(context);
                }
                return _genericRepository;
            }
        }

        public void Dispose()
        {
            context.Dispose();
            context = null;
        }
    }
}
