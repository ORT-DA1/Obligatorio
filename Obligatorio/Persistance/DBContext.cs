using Domain.Entities;
using System.Data.Entity;

namespace Persistance
{
    public class DBContext : DbContext
    {
        public DbSet<Designer> Designers { get; set; }

        public DBContext()
        {
        }
    }
}
