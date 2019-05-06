namespace medicalassitent.web.Data.Entities
{
    using System.ComponentModel.DataAnnotations;
    public class Medicalhistory : IEntity
    {

        public int Id { get; set; }

        [Display(Name = "Paciente")]
        public int Id_Paciente { get; set; }

        [Display(Name = "Motivo de consulta")]
        public string Motivo_Consulta { get; set; }

        [Display(Name = "Antecedente hereditario")]
        public string Antecedente_Hereditario { get; set; }

        [Display(Name = "Antecedente alergico")]
        public string Antecedente_Alergico { get; set; }

        [Display(Name = "Antecedente quirurgicos")]
        public string Antecedente_Quirurjicos { get; set; }

        [Display(Name = "Revision por sistemas")]
        public string Revision_Sistema { get; set; }

        public string Cabeza { get; set; }
        public string Cuello { get; set; }
        public string Torax { get; set; }
        public string Abdomen { get; set; }

        [Display(Name = "Genitales externos")]
        public string Genitales_Externos { get; set; }

        [Display(Name = "Extremidades superiores")]
        public string Extremidades_Superiores { get; set; }

        [Display(Name = "Extremidades inferiores")]
        public string Extremidades_Inferiores { get; set; }
        public string TA { get; set; }
        public string FC { get; set; }
        public string FR { get; set; }
        public string Pulso { get; set; }
        public string Temperatura { get; set; }

        [Display(Name = "Nota de ingreso")]
        public string Nota_Ingreso { get; set; }
         
        public User User { get; set; }
        public bool WasDeleted { get; set; }
    }
}
