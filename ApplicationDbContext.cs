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
            string tiempoInicio = "07:00 AM";
            DateTime inicio = DateTime.Parse(tiempoInicio);
            string tiempoFinal = "05:00 PM";
            DateTime final = DateTime.Parse(tiempoFinal);
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Empleados>().HasKey(e => e.Contrasenia);
            modelBuilder.Entity<Empleados>().Property(e => e.Nombre).HasMaxLength(100);

            modelBuilder.Entity<Movimientos>().Property(m => m.Movimiento).HasMaxLength(100);
            modelBuilder.Entity<Ajustes>().HasData(
                new Ajustes 
                { 
                    Id = 1,
                    DomingoInicio = inicio,
                    LunesInicio = inicio,
                    MartesInicio = inicio,
                    MiercolesInicio = inicio,
                    JuevesInicio = inicio,
                    ViernesInicio = inicio,
                    SabadoInicio = inicio,
                    DomingoFinal = final,
                    LunesFinal = final,
                    MartesFinal = final,
                    MiercolesFinal = final,
                    JuevesFinal = final,
                    ViernesFinal = final,
                    SabadoFinal = final,
                    ISL = Entidades.Ajustes.DiasEspaniol.Lunes,
                    FSL = Entidades.Ajustes.DiasEspaniol.Viernes,
                    Domingo = false,
                    Lunes = true,
                    Martes = true,
                    Miercoles = true,
                    Jueves = true,
                    Viernes = true,
                    Sabado = false
                });
            //modelBuilder.Entity<Ajustes>().HasCheckConstraint("CK_Ajustes_Id", "[Id] = 1");
        }
        public DbSet<Empleados> Empleados => Set<Empleados>();
        public DbSet<Movimientos> Movimientos => Set<Movimientos>();
        public DbSet<Ajustes> Ajustes => Set<Ajustes>();
    }
}
