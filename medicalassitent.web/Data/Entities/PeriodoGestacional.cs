namespace medicalassitent.web.Data.Entities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class PeriodoGestacional
    {

        public int Id { get; set; }

        [Display(Name = "Fecha del ultimo Periodo")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime ultimo_periodo { get; set; }

        public User User { get; set; }

        public bool WasDeleted  { get; set; }
    }
}
