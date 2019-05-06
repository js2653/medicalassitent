namespace medicalassitent.web.Data
{
    using Entities;

    public class HistoryClinicalIncomeRepository : GenericRepository<HistoryClinicalIncome>, IHistoryClinicalIncomeRepository
    {
        public HistoryClinicalIncomeRepository(DataContext context) : base(context)
        {
        }
    }
}
