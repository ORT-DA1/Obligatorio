using Domain.Entities;
using System.Data.Entity;

namespace Persistance
{
    public class ContextDB : DbContext
    {
        public ContextDB() : base() { }

        public DbSet<Designer> Designers { get; set; }

        public DbSet<Administrator> Administrators { get; set; }

        public DbSet<Architect> Architects { get; set; }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Grid> Grids { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public void EmptyTable()
        {
            SaveChanges();
        }

    }
}
