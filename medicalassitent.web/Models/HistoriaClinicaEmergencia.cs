using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicalassitent.web.Models
{
    public class HistoriaClinicaEmergencia
    {

        public int Id_HCEmer { get; set; }


        public int No_Registro { get; set; }


        public int Id_Paciente { get; set; }

        public string Referido { get; set; }


        public string Mo_Emergencia { get; set; }


        public string Ant_ClinicosQ { get; set; }


        public string Me_UsadosRec { get; set; }

        public string Alergias { get; set; }

        public string TA { get; set; }

        public string FC { get; set; }

        public string FR { get; set; }

        public string Pulso { get; set; }

        public string Temp { get; set; }


        public string H_PositivosExF { get; set; }

        public bool Clinica { get; set; }


        public bool Acc_Transito { get; set; }


        public bool Acc_Laboral { get; set; }


        public bool He_Bala { get; set; }

        public bool Politraumatismo { get; set; }

        public string Otros { get; set; }

        public string Hemograma { get; set; }

        public string Orina { get; set; }

        public string Glicemia { get; set; }


        public string Prueba_Embarazo { get; set; }


        public string Otros2 { get; set; }

        public string Radiografias { get; set; }

        public string EKG { get; set; }


        public string Otros3 { get; set; }

        public string Diagnosticos { get; set; }

        public bool Sutura { get; set; }

        public bool Inmovilizacion { get; set; }

        public bool Reanimacion { get; set; }

        public bool Nebulizacion { get; set; }


        public string Otros4 { get; set; }

        public bool Alta { get; set; }

        public bool Ingreso_Hosp { get; set; }


        public bool Ref_Consulta { get; set; }


        public bool Ref_Centro { get; set; }


        public bool Otros5 { get; set; }


        public int Id_Medico { get; set; }
    }
}
