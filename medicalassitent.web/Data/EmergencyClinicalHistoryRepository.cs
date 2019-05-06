namespace medicalassitent.web.Data
{
    using Entities;

    public class EmergencyClinicalHistoryRepository : GenericRepository<EmergencyClinicalHistory>, IEmergencyClinicalHistoryRepository
    {
        public EmergencyClinicalHistoryRepository(DataContext context) : base(context)
        {
        }
    }
}
