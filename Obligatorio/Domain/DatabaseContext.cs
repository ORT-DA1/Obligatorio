namespace Domain
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Entities;

    public partial class DatabaseContext : DbContext
    {
        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Designer> Designers { get; set; }
        public DbSet<Architect> Architects { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Grid> Grids { get; set; }
        public DbSet<DecorativeColumn> DecorativeColumns { get; set; }
        public DbSet<Door> Doors { get; set; }
        public DbSet<Signature> Signatures { get; set; }
        public DbSet<Wall> Walls { get; set; }
        public DbSet<WallBeam> WallBeams { get; set; }
        public DbSet<Window> Windows { get; set; }

        public DatabaseContext()
            : base("name=DatabaseContext")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Grid>().Ignore(g => g.GridStrategy);
        }
    }
}
