using System.ComponentModel;
namespace aspnetcoreapp.Entidades
{
    public class Movimientos
    {
        public int Id { get; set; }
        [DisplayName ("Contraseña")]
        public string Contrasenia { get; set; } = null!;
        public string Movimiento { get; set; } = null!;

        [DisplayName("Día y hora")]
        public DateTime DiaHora { get; set; }
    }
}
