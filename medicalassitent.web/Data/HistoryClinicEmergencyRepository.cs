namespace medicalassitent.web.Data
{
    using Entities;

    public class HistoryClinicEmergencyRepository : GenericRepository<HistoryClinicEmergency>, IHistoryClinicEmergencyRepository
    {
        public HistoryClinicEmergencyRepository(DataContext context) : base(context)
        {
        }
    }
}
