using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicalassitent.web.Models
{
    public class EvolucionDiariaDelPaciente
    {
        [Key]
        public int Evoluciondiariadelpaciente_Id { get; set; }


        public int Id_internamiento { get; set; }


        public int Id_Medico { get; set; }


        public int Id_CentroMedico { get; set; }


        public int Numero_Record { get; set; }


        public DateTime Hora { get; set; }


        public string NotadeEvaluacion { get; set; }
    }
}
