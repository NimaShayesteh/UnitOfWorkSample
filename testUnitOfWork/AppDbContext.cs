using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testUnitOfWork
{
   public class AppDbContext : DbContext
    {
        public AppDbContext()
        {

        }
        static AppDbContext()
        {
            System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<AppDbContext>());
        }


        public  virtual DbSet<Log> Logs { get; set; }
    }
}
