namespace medicalassitent.web.Data.Entities
{
    using System.Linq;
    using System.Threading.Tasks;
    using Entities;

    public class DocumentTypeRepository : GenericRepository<DocumentType>, IDocumentTypeRepository
    {
        public DocumentTypeRepository(DataContext context) : base(context)
        {
        }

        public Task CreateAsync(DocumentTypeRepository entity)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(DocumentTypeRepository entity)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(DocumentTypeRepository entity)
        {
            throw new System.NotImplementedException();
        }

        IQueryable<DocumentTypeRepository> IGenericRepository<DocumentTypeRepository>.GetAll()
        {
            throw new System.NotImplementedException();
        }

        Task<DocumentTypeRepository> IGenericRepository<DocumentTypeRepository>.GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
