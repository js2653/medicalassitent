using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace medicalassitent.web.Models
{
    public class Analitica
    {

       
        public int Id_Analitica { get; set; }

        public int Id_Paciente { get; set; }

        public int Id_Medico { get; set; }

        public DateTime Fecha { get; set; }

        public string No_Historia { get; set; }

        public string Ac_Urico { get; set; }


        public string Albumina { get; set; }


        public string Amilasa { get; set; }


        public string Billirubina { get; set; }


        public string Calcio { get; set; }


        public string Ck_Total { get; set; }


        public string Ck_MB { get; set; }

        public string Col_Total { get; set; }


        public string Col_HDL { get; set; }


        public string Col_LDL { get; set; }

        public string Col_VLDL { get; set; }


        public string CurGluc_Hora { get; set; }


        public string Cloro { get; set; }

        public string Creatinina { get; set; }


        public string Ferritina { get; set; }


        public string Fos_Alcalina { get; set; }

        public string FosfAcTotal { get; set; }


        public string FosfAcNoProst { get; set; }


        public string FosfAcProst { get; set; }


        public string Fosfolipidos { get; set; }


        public string Fosforo { get; set; }


        public string Gluc_Ayunas { get; set; }

        public string Gluc_Prandial { get; set; }


        public string Gluc_Gluc { get; set; }


        public string Gluc_Capilar { get; set; }


        public string Hem_Gluc { get; set; }

        public string GGTP { get; set; }


        public string Hi_Serico { get; set; }


        public string Cap_Hierro { get; set; }


        public string Inm_lgA { get; set; }


        public string Inm_Lgc { get; set; }


        public string Inm_Lgm { get; set; }


        public string Ldh { get; set; }


        public string Lipasa { get; set; }


        public string Lip_Tot { get; set; }

        public string Magnesio { get; set; }


        public string Microal_Cuant { get; set; }


        public string Potasio_K { get; set; }


        public string Prot_Total { get; set; }

        public string Prot_Frac { get; set; }


        public string Sodio_Na { get; set; }


        public string SGCT { get; set; }


        public string SGTP { get; set; }

 
        public string Trigliceridos { get; set; }


        public string Tropl_Cualit { get; set; }


        public string TropT_Cualit { get; set; }


        public string TropT_Cuanti { get; set; }


        public string Urea { get; set; }


        //MICROBIOLOGIA//


        public string Bacil_En { get; set; }


        public string Bacil_Ser { get; set; }


        public string Cultivo { get; set; }


        public string TincGram_en { get; set; }

        //HERMATOLOGIA//

        public string Cont_Sangre { get; set; }


        public string Cont_Nasal { get; set; }


        public string Cont_Retic { get; set; }


        public string Eritrosedimentacion { get; set; }


        public string Falcemia { get; set; }


        public string Hemograma { get; set; }


        public string Hemotozoarios { get; set; }

        public string Tiemp_Prot { get; set; }

        public string Tiemp__Tromb { get; set; }


        public string Tiemp_Sang { get; set; }


        public string Tiemp_Coag { get; set; }

        //SEROLOGIA//

        public string Ant_Feb { get; set; }


        public string ASO_Latex { get; set; }


        public string ASO_Cuant { get; set; }


        public string C3 { get; set; }


        public string C4 { get; set; }


        public string Dengue_Lgg { get; set; }


        public string Dengue_Lgm { get; set; }


        public string Fac_Latex { get; set; }


        public string Fac_Cuant { get; set; }


        public string HTLV { get; set; }


        public string Lep_Lgg { get; set; }

        public string Lep_Lgm { get; set; }


        public string Pcr_Latex { get; set; }


        public string Pcr__Cuant { get; set; }


        public string PCR_Ultra { get; set; }


        public string Prueba_Orina { get; set; }


        public string Prueba_Sangre { get; set; }

        public string Tb_Micodot { get; set; }

        public string Tip_Sang { get; set; }

        public string Prueb_Directa { get; set; }


        public string Prueb_Indirecta { get; set; }


        public string Vdrl { get; set; }

        //PRUEBAS ESPECIALES//

        public string Acido_Folico { get; set; }


        public string Antic_Antit { get; set; }


        public string Anti_Hav { get; set; }


        public string AntiHav_Lgg { get; set; }

        public string AntiHbc { get; set; }


        public string AntiHbe { get; set; }


        public string Hbcg { get; set; }


        public string Cortisol { get; set; }


        public string Cort_Muest { get; set; }


        public string Cort_Pm { get; set; }


        public string Elect_Hb { get; set; }


        public string Elect_MAcid { get; set; }

        public string Estrogenos_Totales { get; set; }


        public string Fsh { get; set; }


        public string HepatB_Ag { get; set; }


        public string Hepat_HVC { get; set; }


        public string Antigeno_Ag { get; set; }


        public string HIV { get; set; }


        public string Hormona_Basal { get; set; }


        public string Hormona_Est { get; set; }


        public string Inmunoglobina { get; set; }


        public string Lh { get; set; }


        public string Progesterona { get; set; }


        public string Prolactina { get; set; }

        public string T3 { get; set; }


        public string T3_Libre { get; set; }


        public string T4 { get; set; }


        public string T4_Libre { get; set; }


        public string Tsh { get; set; }


        public string Testoterona { get; set; }

        public string Tiroglobulina { get; set; }


        public string Toxo_Lgg { get; set; }


        public string Toxo_Lgm { get; set; }


        public string Vitaminas_B { get; set; }



        //INMUNOLOGIA//

        public string Ana { get; set; }


        public string Anti_Dna { get; set; }


        public string Celulas_Le { get; set; }


        public string Monotest { get; set; }

        //MARCADORES TOMORALES//

        public string Alfp { get; set; }


        public string Cea { get; set; }


        public string Cea_15 { get; set; }


        public string Cea_19 { get; set; }


        public string Cea_125 { get; set; }

        //ORINA//

        public string Antidoping_CocMar { get; set; }


        public string Antidoping_Panel { get; set; }


        public string Depur_Creat { get; set; }


        public string Examen_Orina { get; set; }


        public string Proteina_Orina { get; set; }


        public string Proteina_BJ { get; set; }

        //PARASITOGIA//

        public string Coprologico { get; set; }

        public string Coprologico_X2 { get; set; }


        public string Coprologico_X3 { get; set; }


        public string Coprologico_Conc { get; set; }


        public string Dig_Heces { get; set; }


        public string H_Pilory { get; set; }

        public string Oxiuros_Cinta { get; set; }

        public string Rotavirus { get; set; }


        public string Sust_Reduc { get; set; }

        public string Sangre_Oculta { get; set; }


        public string Colera { get; set; }


        public string Otros { get; set; }


        public string Dx { get; set; }
    }
}
