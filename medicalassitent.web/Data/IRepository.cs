
namespace medicalassitent.web.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Entities;
    public interface IRepository
    {
        void AddDocumentType(DocumentType documentType);

        bool DocumentTypeExists(int id);

        DocumentType GetDocumentType(int id);

        IEnumerable<DocumentType> GetDocumentTypes();

        void RemoveDocumentType(DocumentType documentType);

        Task<bool> SaveAllAsync();

        void UpdateDocumentType(DocumentType documentType);
    }
}