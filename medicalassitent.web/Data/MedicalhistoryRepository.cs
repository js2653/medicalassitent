namespace medicalassitent.web.Data
{
    using Entities;

    public class MedicalhistoryRepository : GenericRepository<Medicalhistory>, IMedicalhistoryRepository
    {
        public MedicalhistoryRepository(DataContext context) : base(context)
        {
        }
    }
}
