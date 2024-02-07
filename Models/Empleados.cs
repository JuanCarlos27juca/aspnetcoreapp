using System.ComponentModel.DataAnnotations;
namespace aspnetcoreapp.Entidades
{
    public class Empleados
    {
        [Display(Name = "Contraseña")]
        public string Contrasenia { get; set; } = null!;
        public string Nombre { get; set; } = null!;

        [Display(Name = "Número del empleado")]
        [Required(ErrorMessage = "Se requiere el número del empleado.")]
        [MaxLength(3, ErrorMessage = "Límite de caracteres 3")]
        [RegularExpression("^([0-9]{1,3})$", ErrorMessage = "El número máximo es 999")]
        public string? NumeroEmpleado { get; set; }
        
        [Display(Name = "Puesto de empleado")]
        [MaxLength(50, ErrorMessage = "Límite de caracteres 50")]
        public string? Puesto { get; set; }


        [Display(Name = "Fecha de Ingreso")]
        [Required(ErrorMessage = "Se requiere la fecha de ingreso del empleado.")]
        public DateTime FechaIngreso { get; set; }


        [Display(Name = "Pago x Hora")]
        [Required(ErrorMessage = "Se requiere el pago por hora del empleado.")]
        [RegularExpression(@"^\d+.?\d{0,2}$", ErrorMessage = "Máximo dos decimales.")]
        [Range(0, 99999.99, ErrorMessage = "Cantidad máxima 99999.99")]
        public decimal PagoPorHora { get; set; }

        [Display(Name = "Horas estipuladas")]
        [Required(ErrorMessage = "Ingrese las horas por jornada laboral del empledo.")]
        [RegularExpression("^([0-9]{1,3})$", ErrorMessage = "Las horas exceden la jornada laboral máxima")]
        [MaxLength(3, ErrorMessage = "Límite de caracteres 3")]
        public string HorasEstipuladas { get; set; } = null!;


        [Display(Name = "Fecha de nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [Display(Name = "Dirección del empleado")]
        [MaxLength(200, ErrorMessage = "Límite de caracteres 200")]
        public string Direccion { get; set; } = null!;

        [Display(Name = "Celular del empleado")]
        [Required(ErrorMessage = "Se requiere el número telefónico del empleado.")]
        [RegularExpression("^([0-9]{10})$", ErrorMessage = "Número de celular no válido")]
        [MaxLength(10, ErrorMessage = "Límite de caracteres 10")]
        public string Telefono { get; set; } = null!;

    }
}
