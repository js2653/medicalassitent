namespace medicalassitent.web.Data
{
    using System.Linq;
    using System.Threading.Tasks;
    using Entities;

    public class MedicalCenterRepository : GenericRepository<DocumentType>, IMedicalCenterRepository
    {
        public MedicalCenterRepository(DataContext context) : base(context)
        {
        }

        public Task CreateAsync(MedicalCenter entity)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(MedicalCenter entity)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(MedicalCenter entity)
        {
            throw new System.NotImplementedException();
        }

        IQueryable<MedicalCenter> IGenericRepository<MedicalCenter>.GetAll()
        {
            throw new System.NotImplementedException();
        }

        Task<MedicalCenter> IGenericRepository<MedicalCenter>.GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
