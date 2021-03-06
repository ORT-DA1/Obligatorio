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
        public DbSet<Point> Points { get; set; }
        public DbSet<PriceAndCost> PricesAndCosts { get; set; }
        
        public DbSet<GeneratedDoor> GeneratedDoors { get; set; }
        public DbSet<GeneratedWindow> GeneratedWindows { get; set; }

        public DatabaseContext()
            : base("name=DatabaseContext")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            #region modelBuilder Ignore 
            modelBuilder.Entity<Grid>().Ignore(g => g.GridStrategy);
            #endregion

            #region modelBuilder PK
            modelBuilder.Entity<Grid>().HasKey(g => g.GridId);
            modelBuilder.Entity<Wall>().HasKey(w => w.WallId);
            modelBuilder.Entity<WallBeam>().HasKey(w => w.WallBeamId);
            modelBuilder.Entity<Window>().HasKey(w => w.WindowId);
            modelBuilder.Entity<Architect>().HasKey(a => a.ArchitectId);
            modelBuilder.Entity<Door>().HasKey(d => d.DoorId);
            modelBuilder.Entity<Signature>().HasKey(s => s.SignatureId);
            modelBuilder.Entity<Point>().HasKey(p => p.PointId);
            modelBuilder.Entity<DecorativeColumn>().HasKey(d => d.DecorativeColumnId);
            modelBuilder.Entity<PriceAndCost>().HasKey(pc => pc.PriceAndCostId);

            modelBuilder.Entity<GeneratedDoor>().HasKey(d => d.GeneratedDoorId);
            modelBuilder.Entity<GeneratedWindow>().HasKey(d => d.GeneratedWindowId);
            #endregion

            #region modelBuilder Relations

            modelBuilder.Entity<Wall>()
                .HasOptional(w => w.PriceAndCost);

            modelBuilder.Entity<Window>()
                .HasOptional(w => w.PriceAndCost);

            modelBuilder.Entity<WallBeam>()
                .HasOptional(w => w.PriceAndCost);

            modelBuilder.Entity<Door>()
                .HasOptional(d => d.PriceAndCost);

            modelBuilder.Entity<DecorativeColumn>()
                .HasOptional(d => d.PriceAndCost);


            //modelBuilder.Entity<GeneratedDoor>()
            //    .HasRequired(w => w.Architect);

            //modelBuilder.Entity<GeneratedWindow>()
            //    .HasRequired(w => w.Architect);


            modelBuilder.Entity<Wall>()
                .HasRequired(w => w.Grid);

            modelBuilder.Entity<Window>()
                .HasRequired(w => w.Grid);
            
            modelBuilder.Entity<WallBeam>()
                .HasRequired(w => w.Grid);

            modelBuilder.Entity<Door>()
                .HasRequired(d => d.Grid);

            modelBuilder.Entity<DecorativeColumn>()
                .HasRequired(d => d.Grid);
            
            modelBuilder.Entity<Signature>()
                .HasRequired(s => s.Grid);

            modelBuilder.Entity<Grid>()
                .HasRequired(g => g.Client);

            #endregion
        }

        public void EmptyDataBase()
        {
            Walls.RemoveRange(Walls);
            Windows.RemoveRange(Windows);
            WallBeams.RemoveRange(WallBeams);
            Doors.RemoveRange(Doors);
            DecorativeColumns.RemoveRange(DecorativeColumns);

            Architects.RemoveRange(Architects);
            Administrators.RemoveRange(Administrators);
            Clients.RemoveRange(Clients);
            Designers.RemoveRange(Designers);
            
            SaveChanges();
        }
    }
}
