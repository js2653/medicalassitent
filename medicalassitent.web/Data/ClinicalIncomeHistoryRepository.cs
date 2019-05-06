namespace medicalassitent.web.Data
{
    using Entities;

    public class ClinicalIncomeHistoryRepository : GenericRepository<ClinicalIncomeHistory>, IClinicalIncomeHistoryRepository
    {
        public ClinicalIncomeHistoryRepository(DataContext context) : base(context)
        {
        }
    }
}
