using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicalassitent.web.Models
{
    public class Internamiento
    {

            public int Id_internamiento { get; set; }


            public int Id_Paciente { get; set; }

            public int Id_Medico { get; set; }


            public int Id_CentroMedico { get; set; }


            public int Habitacion { get; set; }


            public int cama { get; set; }

            public bool deAlta { get; set; }

    }
}

