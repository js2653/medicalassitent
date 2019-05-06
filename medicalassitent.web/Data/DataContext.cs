
namespace medicalassitent.web.Data
{
    using medicalassitent.web.Data.Entities;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    public class DataContext : IdentityDbContext<User>
    {
        public DbSet<DocumentType> DocumentTypes { get; set; }
        public DbSet<Analytics> Analytics { get; set; }
        public DbSet<MedicalCenter> MedicalCenters { get; set; }
        public DbSet<CardiovascularEvaluation>  CardiovascularEvaluations { get; set; }
        public DbSet<DailyEvolutionoftheInternalPatient> DailyEvolutionoftheInternalPatients { get; set; }
        public DbSet<Medicalhistory> Medicalhistories { get; set; }
        public DbSet<HistoryClinicalIncome> HistoryClinicalIncomes{ get; set; }
        public DbSet<HistoryClinicEmergency> HistoryClinicEmergencies { get; set; }
        public DataContext(DbContextOptions<DataContext> options):
            base(options)
        {

        }
    }
}
