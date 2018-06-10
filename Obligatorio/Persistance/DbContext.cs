using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Domain.Entities;

namespace Persistance
{
    public class DBContext : DbContext
    {
        public DBContext() : base() { }
        public DbSet<Designer> Designers { get; set; }

        public void EmptyTable()
        {
            SaveChanges();
        }
    }

}
