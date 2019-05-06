namespace medicalassitent.web.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class GestationalPeriod
    {
        public int Id { get; set; }

        public int Id_Medico { get; set; }

        public int Id_internamiento { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Record")]
        public int Numero_Record { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DisplayFormat(DataFormatString = "{0:H:mm}", ApplyFormatInEditMode = false)]
        [DataType(DataType.Time)]
        public DateTime Hora { get; set; }


        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Medicamentos { get; set; }


        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Dosis { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Via { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Frecuencia { get; set; }

        public User User { get; set; }

        public bool WasDeleted { get; set; }
    }
}
