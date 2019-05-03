using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicalassitent.web.Models
{
    public class HistorialClinico
    {
        [Key]
        public int Id_Historial { get; set; }


        public int Id_Paciente { get; set; }


        public string Motivo_Consulta { get; set; }

        public string Antecedente_Hereditario { get; set; }


        public string Antecedente_Alergico { get; set; }

        public string Antecedente_Quirurjicos { get; set; }

        public string Revision_Sistema { get; set; }

        public string Cabeza { get; set; }
        public string Cuello { get; set; }
        public string Torax { get; set; }
        public string Abdomen { get; set; }


        public string Genitales_Externos { get; set; }


        public string Extremidades_Superiores { get; set; }


        public string Extremidades_Inferiores { get; set; }
        public string TA { get; set; }
        public string FC { get; set; }
        public string FR { get; set; }
        public string Pulso { get; set; }
        public string Temperatura { get; set; }


        public string Nota_Ingreso { get; set; }
    }
}
