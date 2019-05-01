using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicalassitent.web.Models
{
    public class OrdenesMedicas
    {

        public int OrdenesMedicas_Id { get; set; }

        public int Id_Medico { get; set; }

        public int Id_internamiento { get; set; }


        public int Numero_Record { get; set; }

        public DateTime Hora { get; set; }



        public string Medicamentos { get; set; }



        public string Dosis { get; set; }


        public string Via { get; set; }


        public string Frecuencia { get; set; }
    }
}
