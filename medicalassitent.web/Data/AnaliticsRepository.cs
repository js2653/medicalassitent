namespace medicalassitent.web.Data.Entities
{
    using System.Linq;
    using System.Threading.Tasks;
    using Entities;
    public class AnalyticsRepositori : GenericRepository<Analytics>, IAnalyticsRepository
    {
        public AnalyticsRepositori(DataContext context) : base(context)
        {

        }

        public Task CreateAsync(AnalyticsRepositori entity)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(AnalyticsRepositori entity)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(AnalyticsRepositori entity)
        {
            throw new System.NotImplementedException();
        }

        IQueryable<AnalyticsRepositori> IGenericRepository<AnalyticsRepositori>.GetAll()
        {
            throw new System.NotImplementedException();
        }

        Task<AnalyticsRepositori> IGenericRepository<AnalyticsRepositori>.GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
