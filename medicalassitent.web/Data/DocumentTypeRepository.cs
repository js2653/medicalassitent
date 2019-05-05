namespace medicalassitent.web.Data
{
    using Entities;

    public class DocumentTypeRepository : GenericRepository<DocumentType>, IDocumentTypeRepository
    {
        public DocumentTypeRepository(DataContext context) : base(context)
        {
        }
    }
}
