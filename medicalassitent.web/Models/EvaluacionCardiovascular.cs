using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicalassitent.web.Models
{
    public class EvaluacionCardiovascular
    {

        public int Id_CardioV { get; set; }


        public int Id_CentroMedico { get; set; }


        public string Sala { get; set; }


        public int Id_Medico { get; set; }


        public int Id_Paciente { get; set; }


        public DateTime Fecha { get; set; }


        public string Diagnostico { get; set; }



        public string ProcQ_Realizar { get; set; }



        public string Alergico { get; set; }



        public string H_Toxicos { get; set; }


        public string H_CardioVascular { get; set; }


        public string SCardio_Actuales { get; set; }


        public string Sonografia { get; set; }

        //Examen fisico

        public string TA { get; set; }


        public string FC { get; set; }


        public string FR { get; set; }


        public string FP { get; set; }


        public string Po2 { get; set; }


        public bool YVY { get; set; }


        public bool FPericardio { get; set; }

        public bool Roncus { get; set; }

        public bool Crepitantes { get; set; }

        public bool Ictericia { get; set; }

        public bool Hepatomegalia { get; set; }

        public bool Esplegnoniegalia { get; set; }

        public bool Ascitis { get; set; }

        public string Laboratorio { get; set; }


        public string Rad_Torax { get; set; }

        public string Electrocardiograma { get; set; }

        // Conclusiones

        public string PCVascular_Dest { get; set; }


        public string Ot_Patologias { get; set; }

        //Riesgo Anestesico
        public string Goodman { get; set; }

        public string Observaciones { get; set; }
    }
}
