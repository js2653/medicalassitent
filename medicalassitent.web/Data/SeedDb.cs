namespace medicalassitent.web.Data
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Entities;
    using medicalassitent.web.Helpers;
    using Microsoft.AspNetCore.Identity;

    public class SeedDb
    {
        private readonly DataContext context;
        private readonly IUserHelper userHelper;
        private Random random;

        public SeedDb(DataContext context, IUserHelper userHelper)
        {
            this.context = context;
            this.userHelper = userHelper;
            this.random = new Random();
        }

        public async Task SeedAsync()
        {
            await this.context.Database.EnsureCreatedAsync();

            var user = await this.userHelper.GetUserByEmalAsync("jpoolvalverde@gmail.com");
            if(user == null)
            {
                user = new User
                {
                    FirstName = "Jean",
                    LastName = "Valverde",
                    Email = "jpoolvalverde@gmail.com",
                    UserName = "jpoolvalverde@gmail.com",
                    PhoneNumber = "18296573101"
                };
                var result = await this.userHelper.AddUserAsync(user, "1234567");
                if(result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("No se pudo crear el usuario en seeder");
                }
            }
            if (!this.context.DocumentTypes.Any())
            {
                this.AddDocumentType("Cedula", user);
                this.AddDocumentType("Pasaporte", user);
                await this.context.SaveChangesAsync();
            }
        }

        private void AddDocumentType(string name, User user)
        {
            this.context.DocumentTypes.Add(new DocumentType
            {
                TipoDeDocumento = name,
                User = user
            });
        }
    }
}
