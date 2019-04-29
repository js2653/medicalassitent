namespace medicalassitent.web.Data
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Entities;

    public class SeedDb
    {
        private readonly DataContext context;
        private Random random;

        public SeedDb(DataContext context)
        {
            this.context = context;
            this.random = new Random();
        }

        public async Task SeedAsync()
        {
            await this.context.Database.EnsureCreatedAsync();

            if (!this.context.DocumentTypes.Any())
            {
                this.AddDocumentType("Cedula");
                this.AddDocumentType("Pasaporte");
                await this.context.SaveChangesAsync();
            }
        }

        private void AddDocumentType(string name)
        {
            this.context.DocumentTypes.Add(new DocumentType
            {
                TipoDeDocumento = name
            });
        }
    }
}
