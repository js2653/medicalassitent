namespace medicalassitent.web.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class CardiovascularEvaluation : IEntity
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Centro Medico")]
        public int Id_CentroMedico { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Sala { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = " Medico")]
        public int Id_Medico { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Paciente")]
        public int Id_Paciente { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DisplayFormat(DataFormatString = "{0:yyy/MM/dd}", ApplyFormatInEditMode = false)]
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Diagnostico { get; set; }


        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Procedimiento Quirurjico a Realizar")]
        public string ProcQ_Realizar { get; set; }


        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Alergico { get; set; }


        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Habitos Toxicos")]
        public string H_Toxicos { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Historia Cardiovascular")]
        public string H_CardioVascular { get; set; }

        [StringLength(30, ErrorMessage = "El campo {0} debe de estar entre {2} y {1} caracteres", MinimumLength = 3)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Sintomas Cardiovascular Actuales")]
        public string SCardio_Actuales { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Sonografia { get; set; }

        //Examen fisico
        [Display(Name = "TA")]
        public string TA { get; set; }

        [Display(Name = "FC")]
        public string FC { get; set; }

        [Display(Name = "FR")]
        public string FR { get; set; }

        [Display(Name = "FP")]
        public string FP { get; set; }

        [Display(Name = "Po2")]
        public string Po2 { get; set; }

        [Display(Name = "YVY")]
        public bool YVY { get; set; }

        [Display(Name = "Frote Pericardio")]
        public bool FPericardio { get; set; }

        public bool Roncus { get; set; }

        public bool Crepitantes { get; set; }

        public bool Ictericia { get; set; }

        public bool Hepatomegalia { get; set; }

        public bool Esplegnoniegalia { get; set; }

        public bool Ascitis { get; set; }

        public string Laboratorio { get; set; }

        [Display(Name = "Radiografia de Torax")]
        public string Rad_Torax { get; set; }

        public string Electrocardiograma { get; set; }

        // Conclusiones
        [Display(Name = "Patologias Cardiovascular Detectadas")]
        public string PCVascular_Dest { get; set; }

        [Display(Name = "Otras Patologias")]
        public string Ot_Patologias { get; set; }

        //Riesgo Anestesico
        public string Goodman { get; set; }

        public string Observaciones { get; set; }

        public User User { get; set; }

        public bool WasDeleted { get; set; }
    }
}
