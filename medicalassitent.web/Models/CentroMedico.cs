using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicalassitent.web.Models
{
    public class CentroMedico
    {

        public int Id_CentroMedico { get; set; }


        public int Id_Medico { get; set; }


        public string Nombre_CentroMedico { get; set; }


        public string Direccion_centroMedico { get; set; }


        public string Telefono { get; set; }


        public string Email { get; set; }



        public string RNC { get; set; }

        public string photo { get; set; }
    }
}
