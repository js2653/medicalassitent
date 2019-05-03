using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicalassitent.web.Models
{
    public class HistorialClinicoIngreso
    {

        public int Id_HistoriadeIngreso { get; set; }


        public int Id_Paciente { get; set; }

        public string MotivodeConsulta { get; set; }

        public string HistoriadelaEnfermedadACtual { get; set; }


        //Antecedentes personales del paciente  patologicos

        public string Niñes { get; set; }

        public string adolecencia { get; set; }

        public string Adulta { get; set; }


        //Antecedentes personales del paciente  patologicos


        //antecedentes personales 
        public string AntecedentesAlergicos { get; set; }

        public string AntecedentesTransfuciones { get; set; }

        public string AntecedentesQuirurgicas { get; set; }

        public string AntecedentesTraumaticas { get; set; }

        public string AntecedentesHospitalarios { get; set; }

        //vicios del paciente


        public string HabitosToxicos { get; set; }


        //Habitad del paciente (lugar donde vive)

        public string Habitad { get; set; }

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

        public string Piel { get; set; }

        public string Cabeza { get; set; }

        public string Cuello { get; set; }

        public string Mamas { get; set; }

        public string CardioPulmonar { get; set; }

        public string GastroINtestinal { get; set; }

        public string GenitoUrinario { get; set; }

        public string MusculoEsqueletico { get; set; }

        public string Neurologico { get; set; }

        public string Psiquiatrico { get; set; }

        public string EndocrinoMetabolico { get; set; }

        public string Hematologico { get; set; }


        //examen fisico general

        public string SV { get; set; }

        public string TA { get; set; }

        public string FC { get; set; }

        public string FR { get; set; }

        public string Temperatura { get; set; }

        public float Peso { get; set; }

        public string cabeza2 { get; set; }

        public string cuello2 { get; set; }

        public string Torax { get; set; }

        public string Corazon { get; set; }

        public string Pulmones { get; set; }

        public string Abdomen { get; set; }

        public string GenitalesExternos { get; set; }

        public string TactoVaginal { get; set; }

        public string TactoRectal { get; set; }

        public string ExtremidadesInferiores { get; set; }

        // impresiones diagnostica

        public string ImpresionDiagnostica { get; set; }

    }
}
