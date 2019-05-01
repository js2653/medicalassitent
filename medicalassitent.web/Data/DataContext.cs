
namespace medicalassitent.web.Data
{
    using medicalassitent.web.Data.Entities;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    public class DataContext : IdentityDbContext<User>
    {
        public DbSet<DocumentType> DocumentTypes { get; set; }

        public DataContext(DbContextOptions<DataContext> options):
            base(options)
        {

        }
    }
}
