namespace medicalassitent.web.Data.Entities
{
using System.ComponentModel.DataAnnotations;

    public class Internment
    {
        public int Id { get; set; }

        [Display(Name = "Paciente")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int Id_Paciente { get; set; }

        public int Id_Medico { get; set; }

        [Display(Name = "Centro medico")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int Id_CentroMedico { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int Habitacion { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public int cama { get; set; }

        public bool deAlta { get; set; }

        public User User { get; set; }

        public bool WasDeleted { get; set; }

    }
}

