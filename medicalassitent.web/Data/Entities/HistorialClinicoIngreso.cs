namespace medicalassitent.web.Data.Entities
{
   using System.ComponentModel.DataAnnotations;
    public class HistorialClinicoIngreso
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Paciente")]
        public int Id_Paciente { get; set; }


        [StringLength(300, ErrorMessage = "El campo {0} debe de estar entre {2} y {1} caracteres", MinimumLength = 3)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Motivo de Consulta")]
        public string MotivodeConsulta { get; set; }

        [StringLength(300, ErrorMessage = "El campo {0} debe de estar entre {2} y {1} caracteres", MinimumLength = 3)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Historial de la enfermedad actual")]
        public string HistoriadelaEnfermedadACtual { get; set; }


        //Antecedentes personales del paciente  patologicos

        public string Niñes { get; set; }

        public string adolecencia { get; set; }

        public string Adulta { get; set; }


        //Antecedentes personales del paciente  patologicos


        //antecedentes personales 
        [Display(Name = "Antecedentes Alergicos")]
        public string AntecedentesAlergicos { get; set; }
        [Display(Name = "Antecedentes transfuciones")]
        public string AntecedentesTransfuciones { get; set; }
        [Display(Name = "Antecedentes Quirurgicas")]
        public string AntecedentesQuirurgicas { get; set; }
        [Display(Name = "Antecedentes traumaticas")]
        public string AntecedentesTraumaticas { get; set; }
        [Display(Name = "Antecedentes Hospitalarios")]
        public string AntecedentesHospitalarios { get; set; }

        //vicios del paciente
        [Display(Name = "Habitos toxicos")]

        public string HabitosToxicos { get; set; }


        //Habitad del paciente (lugar donde vive)
        [Display(Name = "Habitad")]
        [StringLength(30, ErrorMessage = "El campo {0} debe de estar entre {2} y {1} caracteres", MinimumLength = 3)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Habitad { get; set; }
        [Display(Name = "Patron Alimenticio")]
        [StringLength(30, ErrorMessage = "El campo {0} debe de estar entre {2} y {1} caracteres", MinimumLength = 3)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string PatronAlimenticio { get; set; }


        //Heredo Familiar

        public string Padre { get; set; }

        public string Madre { get; set; }

        public string Hermanos { get; set; }

        public string Hijos { get; set; }

        public string Conyugue { get; set; }

        public string Otro { get; set; }

        //Gineco-Obstetricia
        public string Telarquia { get; set; }

        public string Pubarquia { get; set; }

        public string Maenarquia { get; set; }

        public string NodeConyugues { get; set; }

        public string UltimoPapanicolau { get; set; }

        public string Fum { get; set; }

        public string PatronMenstrual { get; set; }


        // revision por sistemas 
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Piel { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Cabeza { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Cuello { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Mamas { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string CardioPulmonar { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string GastroINtestinal { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string GenitoUrinario { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string MusculoEsqueletico { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Neurologico { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Psiquiatrico { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string EndocrinoMetabolico { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Hematologico { get; set; }


        //examen fisico general
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string SV { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string TA { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string FC { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string FR { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Temperatura { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public float Peso { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string cabeza2 { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string cuello2 { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Torax { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Corazon { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Pulmones { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Abdomen { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string GenitalesExternos { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string TactoVaginal { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string TactoRectal { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string ExtremidadesInferiores { get; set; }

        // impresiones diagnostica

        [Display(Name = "Impresion Diagnostica")]
        public string ImpresionDiagnostica { get; set; }

        public User User { get; set; }
        public bool WasDeleted { get; set; }

    }
}
