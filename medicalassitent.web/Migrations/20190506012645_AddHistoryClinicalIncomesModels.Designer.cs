﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using medicalassitent.web.Data;

namespace medicalassitent.web.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190506012645_AddHistoryClinicalIncomesModels")]
    partial class AddHistoryClinicalIncomesModels
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("medicalassitent.web.Data.Entities.Analytics", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ASO_Cuant");

                    b.Property<string>("ASO_Latex");

                    b.Property<string>("Ac_Urico");

                    b.Property<string>("Acido_Folico");

                    b.Property<string>("Albumina");

                    b.Property<string>("Alfp");

                    b.Property<string>("Amilasa");

                    b.Property<string>("Ana");

                    b.Property<string>("Ant_Feb");

                    b.Property<string>("AntiHav_Lgg");

                    b.Property<string>("AntiHbc");

                    b.Property<string>("AntiHbe");

                    b.Property<string>("Anti_Dna");

                    b.Property<string>("Anti_Hav");

                    b.Property<string>("Antic_Antit");

                    b.Property<string>("Antidoping_CocMar");

                    b.Property<string>("Antidoping_Panel");

                    b.Property<string>("Antigeno_Ag");

                    b.Property<string>("Bacil_En");

                    b.Property<string>("Bacil_Ser");

                    b.Property<string>("Billirubina");

                    b.Property<string>("C3");

                    b.Property<string>("C4");

                    b.Property<string>("Calcio");

                    b.Property<string>("Cap_Hierro");

                    b.Property<string>("Cea");

                    b.Property<string>("Cea_125");

                    b.Property<string>("Cea_15");

                    b.Property<string>("Cea_19");

                    b.Property<string>("Celulas_Le");

                    b.Property<string>("Ck_MB");

                    b.Property<string>("Ck_Total");

                    b.Property<string>("Cloro");

                    b.Property<string>("Col_HDL");

                    b.Property<string>("Col_LDL");

                    b.Property<string>("Col_Total");

                    b.Property<string>("Col_VLDL");

                    b.Property<string>("Colera");

                    b.Property<string>("Cont_Nasal");

                    b.Property<string>("Cont_Retic");

                    b.Property<string>("Cont_Sangre");

                    b.Property<string>("Coprologico");

                    b.Property<string>("Coprologico_Conc");

                    b.Property<string>("Coprologico_X2");

                    b.Property<string>("Coprologico_X3");

                    b.Property<string>("Cort_Muest");

                    b.Property<string>("Cort_Pm");

                    b.Property<string>("Cortisol");

                    b.Property<string>("Creatinina");

                    b.Property<string>("Cultivo");

                    b.Property<string>("CurGluc_Hora");

                    b.Property<string>("Dengue_Lgg");

                    b.Property<string>("Dengue_Lgm");

                    b.Property<string>("Depur_Creat");

                    b.Property<string>("Dig_Heces");

                    b.Property<string>("Dx");

                    b.Property<string>("Elect_Hb");

                    b.Property<string>("Elect_MAcid");

                    b.Property<string>("Eritrosedimentacion");

                    b.Property<string>("Estrogenos_Totales");

                    b.Property<string>("Examen_Orina");

                    b.Property<string>("Fac_Cuant");

                    b.Property<string>("Fac_Latex");

                    b.Property<string>("Falcemia");

                    b.Property<DateTime>("Fecha");

                    b.Property<string>("Ferritina");

                    b.Property<string>("Fos_Alcalina");

                    b.Property<string>("FosfAcNoProst");

                    b.Property<string>("FosfAcProst");

                    b.Property<string>("FosfAcTotal");

                    b.Property<string>("Fosfolipidos");

                    b.Property<string>("Fosforo");

                    b.Property<string>("Fsh");

                    b.Property<string>("GGTP");

                    b.Property<string>("Gluc_Ayunas");

                    b.Property<string>("Gluc_Capilar");

                    b.Property<string>("Gluc_Gluc");

                    b.Property<string>("Gluc_Prandial");

                    b.Property<string>("HIV");

                    b.Property<string>("HTLV");

                    b.Property<string>("H_Pilory");

                    b.Property<string>("Hbcg");

                    b.Property<string>("Hem_Gluc");

                    b.Property<string>("Hemograma");

                    b.Property<string>("Hemotozoarios");

                    b.Property<string>("HepatB_Ag");

                    b.Property<string>("Hepat_HVC");

                    b.Property<string>("Hi_Serico");

                    b.Property<string>("Hormona_Basal");

                    b.Property<string>("Hormona_Est");

                    b.Property<int>("Id_Medico");

                    b.Property<int>("Id_Paciente");

                    b.Property<string>("Inm_Lgc");

                    b.Property<string>("Inm_Lgm");

                    b.Property<string>("Inm_lgA");

                    b.Property<string>("Inmunoglobina");

                    b.Property<string>("Ldh");

                    b.Property<string>("Lep_Lgg");

                    b.Property<string>("Lep_Lgm");

                    b.Property<string>("Lh");

                    b.Property<string>("Lip_Tot");

                    b.Property<string>("Lipasa");

                    b.Property<string>("Magnesio");

                    b.Property<string>("Microal_Cuant");

                    b.Property<string>("Monotest");

                    b.Property<string>("No_Historia");

                    b.Property<string>("Otros");

                    b.Property<string>("Oxiuros_Cinta");

                    b.Property<string>("PCR_Ultra");

                    b.Property<string>("Pcr_Latex");

                    b.Property<string>("Pcr__Cuant");

                    b.Property<string>("Potasio_K");

                    b.Property<string>("Progesterona");

                    b.Property<string>("Prolactina");

                    b.Property<string>("Prot_Frac");

                    b.Property<string>("Prot_Total");

                    b.Property<string>("Proteina_BJ");

                    b.Property<string>("Proteina_Orina");

                    b.Property<string>("Prueb_Directa");

                    b.Property<string>("Prueb_Indirecta");

                    b.Property<string>("Prueba_Orina");

                    b.Property<string>("Prueba_Sangre");

                    b.Property<string>("Rotavirus");

                    b.Property<string>("SGCT");

                    b.Property<string>("SGTP");

                    b.Property<string>("Sangre_Oculta");

                    b.Property<string>("Sodio_Na");

                    b.Property<string>("Sust_Reduc");

                    b.Property<string>("T3");

                    b.Property<string>("T3_Libre");

                    b.Property<string>("T4");

                    b.Property<string>("T4_Libre");

                    b.Property<string>("Tb_Micodot");

                    b.Property<string>("Testoterona");

                    b.Property<string>("Tiemp_Coag");

                    b.Property<string>("Tiemp_Prot");

                    b.Property<string>("Tiemp_Sang");

                    b.Property<string>("Tiemp__Tromb");

                    b.Property<string>("TincGram_en");

                    b.Property<string>("Tip_Sang");

                    b.Property<string>("Tiroglobulina");

                    b.Property<string>("Toxo_Lgg");

                    b.Property<string>("Toxo_Lgm");

                    b.Property<string>("Trigliceridos");

                    b.Property<string>("TropT_Cualit");

                    b.Property<string>("TropT_Cuanti");

                    b.Property<string>("Tropl_Cualit");

                    b.Property<string>("Tsh");

                    b.Property<string>("Urea");

                    b.Property<string>("UserId");

                    b.Property<string>("Vdrl");

                    b.Property<string>("Vitaminas_B");

                    b.Property<bool>("WasDeleted");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Analytics");
                });

            modelBuilder.Entity("medicalassitent.web.Data.Entities.CardiovascularEvaluation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Alergico")
                        .IsRequired();

                    b.Property<bool>("Ascitis");

                    b.Property<bool>("Crepitantes");

                    b.Property<string>("Diagnostico")
                        .IsRequired();

                    b.Property<string>("Electrocardiograma");

                    b.Property<bool>("Esplegnoniegalia");

                    b.Property<string>("FC");

                    b.Property<string>("FP");

                    b.Property<bool>("FPericardio");

                    b.Property<string>("FR");

                    b.Property<DateTime>("Fecha");

                    b.Property<string>("Goodman");

                    b.Property<string>("H_CardioVascular")
                        .IsRequired();

                    b.Property<string>("H_Toxicos")
                        .IsRequired();

                    b.Property<bool>("Hepatomegalia");

                    b.Property<bool>("Ictericia");

                    b.Property<int>("Id_CentroMedico");

                    b.Property<int>("Id_Medico");

                    b.Property<int>("Id_Paciente");

                    b.Property<string>("Laboratorio");

                    b.Property<string>("Observaciones");

                    b.Property<string>("Ot_Patologias");

                    b.Property<string>("PCVascular_Dest");

                    b.Property<string>("Po2");

                    b.Property<string>("ProcQ_Realizar")
                        .IsRequired();

                    b.Property<string>("Rad_Torax");

                    b.Property<bool>("Roncus");

                    b.Property<string>("SCardio_Actuales")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Sala")
                        .IsRequired();

                    b.Property<string>("Sonografia")
                        .IsRequired();

                    b.Property<string>("TA");

                    b.Property<string>("UserId");

                    b.Property<bool>("WasDeleted");

                    b.Property<bool>("YVY");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("CardiovascularEvaluations");
                });

            modelBuilder.Entity("medicalassitent.web.Data.Entities.DailyEvolutionoftheInternalPatient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Hora");

                    b.Property<int>("Id_CentroMedico");

                    b.Property<int>("Id_Medico");

                    b.Property<int>("Id_internamiento");

                    b.Property<string>("NotadeEvaluacion")
                        .IsRequired();

                    b.Property<int>("Numero_Record");

                    b.Property<string>("UserId");

                    b.Property<bool>("WasDeleted");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("DailyEvolutionoftheInternalPatients");
                });

            modelBuilder.Entity("medicalassitent.web.Data.Entities.DocumentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TipoDeDocumento")
                        .IsRequired();

                    b.Property<string>("UserId");

                    b.Property<bool>("WasDeleted");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("DocumentTypes");
                });

            modelBuilder.Entity("medicalassitent.web.Data.Entities.HistoryClinicalIncome", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Abdomen")
                        .IsRequired();

                    b.Property<string>("Adulta");

                    b.Property<string>("AntecedentesAlergicos");

                    b.Property<string>("AntecedentesHospitalarios");

                    b.Property<string>("AntecedentesQuirurgicas");

                    b.Property<string>("AntecedentesTransfuciones");

                    b.Property<string>("AntecedentesTraumaticas");

                    b.Property<string>("Cabeza")
                        .IsRequired();

                    b.Property<string>("CardioPulmonar")
                        .IsRequired();

                    b.Property<string>("Conyugue");

                    b.Property<string>("Corazon")
                        .IsRequired();

                    b.Property<string>("Cuello")
                        .IsRequired();

                    b.Property<string>("EndocrinoMetabolico")
                        .IsRequired();

                    b.Property<string>("ExtremidadesInferiores")
                        .IsRequired();

                    b.Property<string>("FC")
                        .IsRequired();

                    b.Property<string>("FR")
                        .IsRequired();

                    b.Property<string>("Fum");

                    b.Property<string>("GastroINtestinal")
                        .IsRequired();

                    b.Property<string>("GenitalesExternos")
                        .IsRequired();

                    b.Property<string>("GenitoUrinario")
                        .IsRequired();

                    b.Property<string>("Habitad")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("HabitosToxicos");

                    b.Property<string>("Hematologico")
                        .IsRequired();

                    b.Property<string>("Hermanos");

                    b.Property<string>("Hijos");

                    b.Property<string>("HistoriadelaEnfermedadACtual")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<int>("Id_Paciente");

                    b.Property<string>("ImpresionDiagnostica");

                    b.Property<string>("Madre");

                    b.Property<string>("Maenarquia");

                    b.Property<string>("Mamas")
                        .IsRequired();

                    b.Property<string>("MotivodeConsulta")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<string>("MusculoEsqueletico")
                        .IsRequired();

                    b.Property<string>("Neurologico")
                        .IsRequired();

                    b.Property<string>("Niñes");

                    b.Property<string>("NodeConyugues");

                    b.Property<string>("Otro");

                    b.Property<string>("Padre");

                    b.Property<string>("PatronAlimenticio")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("PatronMenstrual");

                    b.Property<float>("Peso");

                    b.Property<string>("Piel")
                        .IsRequired();

                    b.Property<string>("Psiquiatrico")
                        .IsRequired();

                    b.Property<string>("Pubarquia");

                    b.Property<string>("Pulmones")
                        .IsRequired();

                    b.Property<string>("SV")
                        .IsRequired();

                    b.Property<string>("TA")
                        .IsRequired();

                    b.Property<string>("TactoRectal")
                        .IsRequired();

                    b.Property<string>("TactoVaginal")
                        .IsRequired();

                    b.Property<string>("Telarquia");

                    b.Property<string>("Temperatura")
                        .IsRequired();

                    b.Property<string>("Torax")
                        .IsRequired();

                    b.Property<string>("UltimoPapanicolau");

                    b.Property<string>("UserId");

                    b.Property<bool>("WasDeleted");

                    b.Property<string>("adolecencia");

                    b.Property<string>("cabeza2")
                        .IsRequired();

                    b.Property<string>("cuello2")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("HistoryClinicalIncomes");
                });

            modelBuilder.Entity("medicalassitent.web.Data.Entities.MedicalCenter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Direccion_centroMedico")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<int>("Id_Medico");

                    b.Property<string>("Nombre_CentroMedico")
                        .IsRequired();

                    b.Property<string>("RNC")
                        .IsRequired();

                    b.Property<string>("Telefono")
                        .IsRequired();

                    b.Property<string>("UserId");

                    b.Property<bool>("WasDeleted");

                    b.Property<string>("photo");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("MedicalCenters");
                });

            modelBuilder.Entity("medicalassitent.web.Data.Entities.Medicalhistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Abdomen");

                    b.Property<string>("Antecedente_Alergico");

                    b.Property<string>("Antecedente_Hereditario");

                    b.Property<string>("Antecedente_Quirurjicos");

                    b.Property<string>("Cabeza");

                    b.Property<string>("Cuello");

                    b.Property<string>("Extremidades_Inferiores");

                    b.Property<string>("Extremidades_Superiores");

                    b.Property<string>("FC");

                    b.Property<string>("FR");

                    b.Property<string>("Genitales_Externos");

                    b.Property<int>("Id_Paciente");

                    b.Property<string>("Motivo_Consulta");

                    b.Property<string>("Nota_Ingreso");

                    b.Property<string>("Pulso");

                    b.Property<string>("Revision_Sistema");

                    b.Property<string>("TA");

                    b.Property<string>("Temperatura");

                    b.Property<string>("Torax");

                    b.Property<string>("UserId");

                    b.Property<bool>("WasDeleted");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Medicalhistories");
                });

            modelBuilder.Entity("medicalassitent.web.Data.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("medicalassitent.web.Data.Entities.Analytics", b =>
                {
                    b.HasOne("medicalassitent.web.Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("medicalassitent.web.Data.Entities.CardiovascularEvaluation", b =>
                {
                    b.HasOne("medicalassitent.web.Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("medicalassitent.web.Data.Entities.DailyEvolutionoftheInternalPatient", b =>
                {
                    b.HasOne("medicalassitent.web.Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("medicalassitent.web.Data.Entities.DocumentType", b =>
                {
                    b.HasOne("medicalassitent.web.Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("medicalassitent.web.Data.Entities.HistoryClinicalIncome", b =>
                {
                    b.HasOne("medicalassitent.web.Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("medicalassitent.web.Data.Entities.MedicalCenter", b =>
                {
                    b.HasOne("medicalassitent.web.Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("medicalassitent.web.Data.Entities.Medicalhistory", b =>
                {
                    b.HasOne("medicalassitent.web.Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("medicalassitent.web.Data.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("medicalassitent.web.Data.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("medicalassitent.web.Data.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("medicalassitent.web.Data.Entities.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
