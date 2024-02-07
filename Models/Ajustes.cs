using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace aspnetcoreapp.Entidades
{
    public class Ajustes
    {
        [DefaultValue("1")]
        [Key]
        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:t}", ApplyFormatInEditMode = true)]
        [Display(Name = "Domingo inicio")]
        public DateTime DomingoInicio { get; set; }

        [DisplayFormat(DataFormatString = "{0:t}", ApplyFormatInEditMode = true)]
        [Display(Name = "Lunes inicio")]
        public DateTime LunesInicio { get; set; }

        [DisplayFormat(DataFormatString = "{0:t}", ApplyFormatInEditMode = true)]
        [Display(Name = "Martes inicio")]
        public DateTime MartesInicio { get; set; }

        [DisplayFormat(DataFormatString = "{0:t}", ApplyFormatInEditMode = true)]
        [Display(Name = "Miércoles inicio")]
        public DateTime MiercolesInicio { get; set; }

        [DisplayFormat(DataFormatString = "{0:t}", ApplyFormatInEditMode = true)]
        [Display(Name = "Jueves inicio")]
        public DateTime JuevesInicio { get; set; }

        [DisplayFormat(DataFormatString = "{0:t}", ApplyFormatInEditMode = true)]
        [Display(Name = "Viernes inicio")]
        public DateTime ViernesInicio { get; set; }

        [DisplayFormat(DataFormatString = "{0:t}", ApplyFormatInEditMode = true)]
        [Display(Name = "Sábado inicio")]
        public DateTime SabadoInicio { get; set; }

        [DisplayFormat(DataFormatString = "{0:t}", ApplyFormatInEditMode = true)]
        [Display(Name = "Domingo final")]
        public DateTime DomingoFinal { get; set; }

        [DisplayFormat(DataFormatString = "{0:t}", ApplyFormatInEditMode = true)]
        [Display(Name = "Lunes final")]
        public DateTime LunesFinal { get; set; }

        [DisplayFormat(DataFormatString = "{0:t}", ApplyFormatInEditMode = true)]
        [Display(Name = "Martes final")]
        public DateTime MartesFinal { get; set; }

        [DisplayFormat(DataFormatString = "{0:t}", ApplyFormatInEditMode = true)]
        [Display(Name = "Miércoles final")]
        public DateTime MiercolesFinal { get; set; }

        [DisplayFormat(DataFormatString = "{0:t}", ApplyFormatInEditMode = true)]
        [Display(Name = "Jueves final")]
        public DateTime JuevesFinal { get; set; }

        [DisplayFormat(DataFormatString = "{0:t}", ApplyFormatInEditMode = true)]
        [Display(Name = "Viernes final")]
        public DateTime ViernesFinal { get; set; }

        [DisplayFormat(DataFormatString = "{0:t}", ApplyFormatInEditMode = true)]
        [Display(Name = "Sábado final")]
        public DateTime SabadoFinal { get; set; }
        public enum DiasEspaniol
        {
            Domingo,
            Lunes,
            Martes,
            Miercoles,
            Jueves,
            Viernes,
            Sabado
        }
        [Display(Name = "Inicio Semana Laboral")]
        public DiasEspaniol ISL { get; set; }

        [Display(Name = "Fin Semana Laboral")]
        public DiasEspaniol FSL { get; set; }
        public bool Domingo { get; set; }
        public bool Lunes { get; set; }
        public bool Martes { get; set; }
        public bool Miercoles { get; set; }
        public bool Jueves { get; set; }
        public bool Viernes { get; set; }
        public bool Sabado { get; set; }
    }
}
