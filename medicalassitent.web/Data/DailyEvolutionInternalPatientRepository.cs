namespace medicalassitent.web.Data
{
    using Entities;

    public class DailyEvolutionInternalPatientRepository : GenericRepository<DailyEvolutionInternalPatient>, IDailyEvolutionInternalPatientRepository
    {
        public DailyEvolutionInternalPatientRepository(DataContext context) : base(context)
        {
        }
    }
}
