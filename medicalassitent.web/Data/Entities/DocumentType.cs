namespace medicalassitent.web.Data.Entities
{
    using System.ComponentModel.DataAnnotations;
    public class DocumentType
    {
        public int Id { get; set; }

        [Display(Name = "Documento")]
        [Required(ErrorMessage = "El campo {0} es obligtorio")]
        public string TipoDeDocumento { get; set; }

        //public virtual ICollection<Persona> Personas { get; set; }
    }
}
