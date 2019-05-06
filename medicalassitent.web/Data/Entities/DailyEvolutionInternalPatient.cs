namespace medicalassitent.web.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class DailyEvolutionInternalPatient : IEntity
    {
       
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Paciente")]
        public int Id_internamiento { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Medico")]
        public int Id_Medico { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Centro medico")]
        public int Id_CentroMedico { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Record")]
        public int Numero_Record { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd H:mm:ss}", ApplyFormatInEditMode = false)]
        [DataType(DataType.Time)]
        public DateTime Hora { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Nota de evaluacion")]
        public string NotadeEvaluacion { get; set; }

        public User User { get; set; }
        public bool WasDeleted { get; set; }
        
    }
}
