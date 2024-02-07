using aspnetcoreapp.Entidades;
using Microsoft.EntityFrameworkCore;

namespace aspnetcoreapp
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Empleados>().HasKey(e => e.Contrasenia);
            modelBuilder.Entity<Empleados>().Property(e => e.Nombre).HasMaxLength(100);

            modelBuilder.Entity<Movimientos>().Property(m => m.Movimiento).HasMaxLength(100);
            //modelBuilder.Entity<Ajustes>().HasCheckConstraint("CK_Ajustes_Id", "[Id] = 1");
        }
        public DbSet<Empleados> Empleados => Set<Empleados>();
        public DbSet<Movimientos> Movimientos => Set<Movimientos>();
        public DbSet<Ajustes> Ajustes => Set<Ajustes>();
    }
}
