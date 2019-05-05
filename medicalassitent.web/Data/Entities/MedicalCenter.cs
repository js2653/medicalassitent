namespace medicalassitent.web.Data.Entities
{
    using System.ComponentModel.DataAnnotations;
    public class MedicalCenter : IEntity
    {

        public int Id { get; set; }

        [Display(Name = "Medico")]
        public int Id_Medico { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Nombre del Centro")]
        public string Nombre_CentroMedico { get; set; }

        [Display(Name = "Direccion")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Direccion_centroMedico { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:###-##-####}")]
        [DataType(DataType.PhoneNumber)]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "E-Mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string RNC { get; set; }

        [DataType(DataType.ImageUrl)]
        [Display(Name = "Foto")]
        public string photo { get; set; }

        public User User { get; set; }
        public bool WasDeleted { get; set; }
    }
}
