namespace medicalassitent.web.Data
{
    using Entities;

    public class DailyEvolutionoftheInternalPatientRepository : GenericRepository<DailyEvolutionoftheInternalPatient>, IDailyEvolutionoftheInternalPatientRepository
    {
        public DailyEvolutionoftheInternalPatientRepository(DataContext context) : base(context)
        {
        }
    }
}
