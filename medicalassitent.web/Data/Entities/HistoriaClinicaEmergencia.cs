namespace medicalassitent.web.Data.Entities
{
 using System.ComponentModel.DataAnnotations;
    public class HistoriaClinicaEmergencia
    {
    
        public int Id { get; set; }

        [Display(Name = "No.Reg.")]
        public int No_Registro { get; set; }

        [Display(Name = "Paciente")]
        public int Id_Paciente { get; set; }

        public string Referido { get; set; }

        [Display(Name = "Motivo de Emergencia")]
        public string Mo_Emergencia { get; set; }

        [Display(Name = "Antecedentes Clinico o Quirurjicos")]
        public string Ant_ClinicosQ { get; set; }

        [Display(Name = "Medicamentos que ha usado recientemente")]
        public string Me_UsadosRec { get; set; }

        public string Alergias { get; set; }

        public string TA { get; set; }

        public string FC { get; set; }

        public string FR { get; set; }

        public string Pulso { get; set; }

        public string Temp { get; set; }

        [Display(Name = "Hallazgos positivos del examen fisico")]
        public string H_PositivosExF { get; set; }

        public bool Clinica { get; set; }

        [Display(Name = "Accidente de transito")]
        public bool Acc_Transito { get; set; }

        [Display(Name = "Accidente laboral")]
        public bool Acc_Laboral { get; set; }

        [Display(Name = "Herida de bala")]
        public bool He_Bala { get; set; }

        public bool Politraumatismo { get; set; }

        public string Otros { get; set; }

        public string Hemograma { get; set; }

        public string Orina { get; set; }

        public string Glicemia { get; set; }

        [Display(Name = "Prueba de embarazo")]
        public string Prueba_Embarazo { get; set; }

        [Display(Name = "Otros")]
        public string Otros2 { get; set; }

        public string Radiografias { get; set; }

        public string EKG { get; set; }

        [Display(Name = "Otros")]
        public string Otros3 { get; set; }

        public string Diagnosticos { get; set; }

        public bool Sutura { get; set; }

        public bool Inmovilizacion { get; set; }

        public bool Reanimacion { get; set; }

        public bool Nebulizacion { get; set; }

        [Display(Name = "Otros")]
        public string Otros4 { get; set; }

        public bool Alta { get; set; }

        [Display(Name = "Ingreso hospital")]
        public bool Ingreso_Hosp { get; set; }

        [Display(Name = "Referido a consulta")]
        public bool Ref_Consulta { get; set; }

        [Display(Name = "Referencia a otro centro")]
        public bool Ref_Centro { get; set; }

        [Display(Name = "Otros")]
        public bool Otros5 { get; set; }

        [Display(Name = "Medico")]
        public int Id_Medico { get; set; }

        public User User { get; set; }
        public bool WasDeleted { get; set; }
    }
}
