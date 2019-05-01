namespace medicalassitent.web.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Entities;

    public class Repository : IRepository
    {
        private readonly DataContext context;

        public Repository(DataContext context)
        {
            this.context = context;
        }

        // DocumentType
        #region MyRegion
        public IEnumerable<DocumentType> GetDocumentTypes()
        {
            return this.context.DocumentTypes.OrderBy(d => d.TipoDeDocumento);
        }

        public DocumentType GetDocumentType(int id)
        {
            return this.context.DocumentTypes.Find(id);
        }

        public void AddDocumentType(DocumentType documentType)
        {
            this.context.DocumentTypes.Add(documentType);
        }

        public void UpdateDocumentType(DocumentType documentType)
        {
            this.context.Update(documentType);
        }

        public void RemoveDocumentType(DocumentType documentType)
        {
            this.context.DocumentTypes.Remove(documentType);
        }

        public async Task<bool> SaveAllAsync()
        {
            return await this.context.SaveChangesAsync() > 0;
        }

        public bool DocumentTypeExists(int id)
        {
            return this.context.DocumentTypes.Any(p => p.Id == id);
        }
        #endregion
        //
    }
}
