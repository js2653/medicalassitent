namespace medicalassitent.web.Data.Entities
{
    using System.ComponentModel.DataAnnotations;
    public class DocumentType:IEntity
    {
        public int Id { get; set; }

        [Display(Name = "Documentos")]
        [Required(ErrorMessage = "El campo {0} es obligtorio")]
        public string TipoDeDocumento { get; set; }

        public User User { get; set; }
        public bool WasDeleted { get ; set; }
    }
}
