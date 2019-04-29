namespace medicalassitent.web.Data
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Linq;
    using medicalassitent.web.Data.Entities;

    public class Repository
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
