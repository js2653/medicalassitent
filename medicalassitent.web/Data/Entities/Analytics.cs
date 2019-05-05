
namespace medicalassitent.web.Data.Entities

{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Analytics : IEntity
    {

     
        public int Id { get; set; }

        public int Id_Paciente { get; set; }

        public int Id_Medico { get; set; }

        [Display(Name = "Fecha")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = false)]
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }

        [Display(Name = "No.Historia")]
        public string No_Historia { get; set; }

        [Display(Name = "Acido Urico(Suero)")]
        public string Ac_Urico { get; set; }

        [Display(Name = "Albumina")]
        public string Albumina { get; set; }

        [Display(Name = "Amilasa")]
        public string Amilasa { get; set; }

        [Display(Name = "Billirubina Total y Frac")]
        public string Billirubina { get; set; }

        [Display(Name = "Calcio")]
        public string Calcio { get; set; }

        [Display(Name = "Ck Total")]
        public string Ck_Total { get; set; }

        [Display(Name = "Ck MB")]
        public string Ck_MB { get; set; }

        [Display(Name = "Colesterol Total")]
        public string Col_Total { get; set; }

        [Display(Name = "Colesterol HDL")]
        public string Col_HDL { get; set; }

        [Display(Name = "Colesterol LDL ")]
        public string Col_LDL { get; set; }

        [Display(Name = "Colesterol VLDL ")]
        public string Col_VLDL { get; set; }

        [Display(Name = "Curva de Glucosa_Hora ")]
        public string CurGluc_Hora { get; set; }

        [Display(Name = "Cloro ")]
        public string Cloro { get; set; }

        [Display(Name = "Creatinina")]
        public string Creatinina { get; set; }

        [Display(Name = "Ferritina")]
        public string Ferritina { get; set; }

        [Display(Name = "Fosfatasa Alcalina")]
        public string Fos_Alcalina { get; set; }

        [Display(Name = "Fosfatasa Acida Total")]
        public string FosfAcTotal { get; set; }

        [Display(Name = "Fosfatasa Acida no Prost.")]
        public string FosfAcNoProst { get; set; }

        [Display(Name = "Fosfatasa Acida Prostatica")]
        public string FosfAcProst { get; set; }

        [Display(Name = "Fosfolipidos ")]
        public string Fosfolipidos { get; set; }

        [Display(Name = "Fosforo")]
        public string Fosforo { get; set; }

        [Display(Name = "Glucosa (Ayunas)")]
        public string Gluc_Ayunas { get; set; }

        [Display(Name = "Glucosa (Pre y Post Prandial)")]
        public string Gluc_Prandial { get; set; }

        [Display(Name = "Glucosa preyPost Craga de Glucosa ")]
        public string Gluc_Gluc { get; set; }

        [Display(Name = "Glucosa Capilar")]
        public string Gluc_Capilar { get; set; }

        [Display(Name = "Hemoglobina Glucosilada")]
        public string Hem_Gluc { get; set; }

        [Display(Name = "GGTP")]
        public string GGTP { get; set; }

        [Display(Name = "Hierro Serico ")]
        public string Hi_Serico { get; set; }

        [Display(Name = "Captacion de Hierro ")]
        public string Cap_Hierro { get; set; }

        [Display(Name = "Inmunoglobina A (lgA) ")]
        public string Inm_lgA { get; set; }

        [Display(Name = "Inmunoglobina G (lgG)")]
        public string Inm_Lgc { get; set; }

        [Display(Name = "Inmunoglobina M (lgM)")]
        public string Inm_Lgm { get; set; }

        [Display(Name = "LDH")]
        public string Ldh { get; set; }

        [Display(Name = "Lipasa")]
        public string Lipasa { get; set; }

        [Display(Name = "Lipidos Totales")]
        public string Lip_Tot { get; set; }

        [Display(Name = "Magnesio")]
        public string Magnesio { get; set; }

        [Display(Name = "microalbumina Cuant.")]
        public string Microal_Cuant { get; set; }

        [Display(Name = "Potasio (K)")]
        public string Potasio_K { get; set; }

        [Display(Name = "Proteinas Total")]
        public string Prot_Total { get; set; }

        [Display(Name = "Proteinas Total Fraccionada")]
        public string Prot_Frac { get; set; }

        [Display(Name = "Sodio (Na)")]
        public string Sodio_Na { get; set; }

        [Display(Name = "SGCT")]
        public string SGCT { get; set; }

        [Display(Name = "SGTP")]
        public string SGTP { get; set; }

        [Display(Name = "Trigliceridos")]
        public string Trigliceridos { get; set; }

        [Display(Name = "Troponona | Cualitativa")]
        public string Tropl_Cualit { get; set; }

        [Display(Name = "Troponona T Cualitativa")]
        public string TropT_Cualit { get; set; }

        [Display(Name = "Troponona T Cuantitativa")]
        public string TropT_Cuanti { get; set; }

        [Display(Name = "Urea")]
        public string Urea { get; set; }


        //MICROBIOLOGIA//

        [Display(Name = "Baciloscopia en:")]
        public string Bacil_En { get; set; }

        [Display(Name = "Baciloscopia seriada en:")]
        public string Bacil_Ser { get; set; }

        [Display(Name = "Cultivo")]
        public string Cultivo { get; set; }

        [Display(Name = "Tincion de Gram. en:")]
        public string TincGram_en { get; set; }

        //HERMATOLOGIA//
        [Display(Name = "Conteo de Eosinofilos (Sangre)")]
        public string Cont_Sangre { get; set; }

        [Display(Name = "Conteo de Eosinofilos (Nasal)")]
        public string Cont_Nasal { get; set; }

        [Display(Name = "Conteo de Reticulocitos")]
        public string Cont_Retic { get; set; }

        [Display(Name = "Eritrosedimentacion")]
        public string Eritrosedimentacion { get; set; }

        [Display(Name = "Falcemia")]
        public string Falcemia { get; set; }

        [Display(Name = "Hemograma")]
        public string Hemograma { get; set; }

        [Display(Name = "Hematozoroarios")]
        public string Hemotozoarios { get; set; }

        [Display(Name = "Tiempo de Protrombina")]
        public string Tiemp_Prot { get; set; }

        [Display(Name = "Tiempo Parcial de Tromboplastina")]
        public string Tiemp__Tromb { get; set; }

        [Display(Name = "Tiempo de Sangria")]
        public string Tiemp_Sang { get; set; }

        [Display(Name = "Tiempo de Coagulacion")]
        public string Tiemp_Coag { get; set; }

        //SEROLOGIA//
        [Display(Name = "Antigeno Febriles")]
        public string Ant_Feb { get; set; }

        [Display(Name = "ASO Latex")]
        public string ASO_Latex { get; set; }

        [Display(Name = "ASO Cuant.")]
        public string ASO_Cuant { get; set; }

        [Display(Name = "C3")]
        public string C3 { get; set; }

        [Display(Name = "C4")]
        public string C4 { get; set; }

        [Display(Name = "Dengue lgG")]
        public string Dengue_Lgg { get; set; }

        [Display(Name = "Dengue lgM")]
        public string Dengue_Lgm { get; set; }

        [Display(Name = "Factor Reumatoide Latex")]
        public string Fac_Latex { get; set; }

        [Display(Name = "Factor Reumatoide Latex Cuant.")]
        public string Fac_Cuant { get; set; }

        [Display(Name = "HTLV 1/2")]
        public string HTLV { get; set; }

        [Display(Name = "Leptospira lgG")]
        public string Lep_Lgg { get; set; }

        [Display(Name = "Leptospira lgM")]
        public string Lep_Lgm { get; set; }

        [Display(Name = "PCR Latex")]
        public string Pcr_Latex { get; set; }

        [Display(Name = "PCR Latex Cuant.")]
        public string Pcr__Cuant { get; set; }

        [Display(Name = "PCR Ultrasensible")]
        public string PCR_Ultra { get; set; }

        [Display(Name = "Prueba de Embarazo con Orina")]
        public string Prueba_Orina { get; set; }

        [Display(Name = "Prueba de Embarazo con Sangre")]
        public string Prueba_Sangre { get; set; }

        [Display(Name = "TB en Sangre (Micodot)")]
        public string Tb_Micodot { get; set; }

        [Display(Name = "Tipificacion Sanguinea")]
        public string Tip_Sang { get; set; }

        [Display(Name = "Prueba de Coombs Directa")]
        public string Prueb_Directa { get; set; }

        [Display(Name = "Prueba de Coombs Indirecta")]
        public string Prueb_Indirecta { get; set; }

        [Display(Name = "VDRL")]
        public string Vdrl { get; set; }

        //PRUEBAS ESPECIALES//
        [Display(Name = "Acido Folico")]
        public string Acido_Folico { get; set; }

        [Display(Name = "Anticuerpos antitiroideos")]
        public string Antic_Antit { get; set; }

        [Display(Name = "Anti-HAV")]
        public string Anti_Hav { get; set; }

        [Display(Name = "Anti-HAV lgG")]
        public string AntiHav_Lgg { get; set; }

        [Display(Name = "Anti-HBC(lgM anticore lgM)")]
        public string AntiHbc { get; set; }

        [Display(Name = "Anti-HBe")]
        public string AntiHbe { get; set; }

        [Display(Name = "HBCG")]
        public string Hbcg { get; set; }

        [Display(Name = "Cortisol")]
        public string Cortisol { get; set; }

        [Display(Name = "Cortisol 2 muestra(A.M. - P.M.)")]
        public string Cort_Muest { get; set; }

        [Display(Name = "Cortisol P.M")]
        public string Cort_Pm { get; set; }

        [Display(Name = "Electroforesis de Hb.")]
        public string Elect_Hb { get; set; }

        [Display(Name = "Electroforesis de Hb. Media Acida")]
        public string Elect_MAcid { get; set; }

        [Display(Name = "Estrogenos Totales")]
        public string Estrogenos_Totales { get; set; }

        [Display(Name = "FSH")]
        public string Fsh { get; set; }

        [Display(Name = "Hepatitis B(HBs-Ag")]
        public string HepatB_Ag { get; set; }

        [Display(Name = "Hepatitis C(HVC)")]
        public string Hepat_HVC { get; set; }

        [Display(Name = "Antigeno E del Hep B(HBe-Ag)")]
        public string Antigeno_Ag { get; set; }

        [Display(Name = "HIV")]
        public string HIV { get; set; }

        [Display(Name = "Hormona de Crec. Basal")]
        public string Hormona_Basal { get; set; }

        [Display(Name = "Hormona de Crec. Post. Est.")]
        public string Hormona_Est { get; set; }

        [Display(Name = "Inmunoglobina")]
        public string Inmunoglobina { get; set; }

        [Display(Name = "LH")]
        public string Lh { get; set; }

        [Display(Name = "Progesterona")]
        public string Progesterona { get; set; }

        [Display(Name = "Prolactina")]
        public string Prolactina { get; set; }

        [Display(Name = "T3")]
        public string T3 { get; set; }

        [Display(Name = "T3 Libre")]
        public string T3_Libre { get; set; }

        [Display(Name = "T4")]
        public string T4 { get; set; }

        [Display(Name = "T4 Libre")]
        public string T4_Libre { get; set; }

        [Display(Name = "TSH")]
        public string Tsh { get; set; }

        [Display(Name = "Testoterona")]
        public string Testoterona { get; set; }

        [Display(Name = "Tiroglobulina")]
        public string Tiroglobulina { get; set; }

        [Display(Name = "Toxo lgG")]
        public string Toxo_Lgg { get; set; }

        [Display(Name = "lgM")]
        public string Toxo_Lgm { get; set; }

        [Display(Name = "Vitamina B12")]
        public string Vitaminas_B { get; set; }



        //INMUNOLOGIA//
        [Display(Name = "ANA")]
        public string Ana { get; set; }

        [Display(Name = "Anti-DNA")]
        public string Anti_Dna { get; set; }

        [Display(Name = "Celulas L.E.")]
        public string Celulas_Le { get; set; }

        [Display(Name = "Monotest")]
        public string Monotest { get; set; }

        //MARCADORES TOMORALES//
        [Display(Name = "Alfa Feto Proteina(AFP)")]
        public string Alfp { get; set; }

        [Display(Name = "CEA")]
        public string Cea { get; set; }

        [Display(Name = "CEA 15.3")]
        public string Cea_15 { get; set; }

        [Display(Name = "CEA 19.9")]
        public string Cea_19 { get; set; }

        [Display(Name = "CEA 125")]
        public string Cea_125 { get; set; }

        //ORINA//
        [Display(Name = "Antidoping(Cocaina y Mariguana)")]
        public string Antidoping_CocMar { get; set; }

        [Display(Name = "Antidoping(Panel 7-Panel 9)")]
        public string Antidoping_Panel { get; set; }

        [Display(Name = "Depuracion de Creatinina")]
        public string Depur_Creat { get; set; }

        [Display(Name = "Examen Gral. de Orina")]
        public string Examen_Orina { get; set; }

        [Display(Name = "Proteina en Orina de 24 Horas")]
        public string Proteina_Orina { get; set; }

        [Display(Name = "Proteina de Bence Jones")]
        public string Proteina_BJ { get; set; }

        //PARASITOGIA//
        [Display(Name = "Cropologico")]
        public string Coprologico { get; set; }

        [Display(Name = "Cropologico X2")]
        public string Coprologico_X2 { get; set; }

        [Display(Name = "Cropologico X3")]
        public string Coprologico_X3 { get; set; }

        [Display(Name = "Cropologico por Concentracion")]
        public string Coprologico_Conc { get; set; }

        [Display(Name = "Digestion de Heces")]
        public string Dig_Heces { get; set; }

        [Display(Name = "H. Pilory en Heces")]
        public string H_Pilory { get; set; }

        [Display(Name = "Oxiuros(Cinta Adhesiva)")]
        public string Oxiuros_Cinta { get; set; }

        [Display(Name = "Rotavirus")]
        public string Rotavirus { get; set; }

        [Display(Name = "Sust. Reductoras")]
        public string Sust_Reduc { get; set; }

        [Display(Name = "Sangre Oculta")]
        public string Sangre_Oculta { get; set; }

        [Display(Name = "Colera")]
        public string Colera { get; set; }

        [Display(Name = "Otros")]
        public string Otros { get; set; }

        [Display(Name = "DX")]
        public string Dx { get; set; }
        
        public User User { get; set; }
        public bool WasDeleted { get; set; }
    }
}
