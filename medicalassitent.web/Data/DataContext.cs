
namespace medicalassitent.web.Data
{
    using medicalassitent.web.Data.Entities;
    using Microsoft.EntityFrameworkCore;
    public class DataContext : DbContext
    {
        public DbSet<DocumentType> DocumentTypes { get; set; }

        public DataContext(DbContextOptions<DataContext> options):
            base(options)
        {

        }
    }
}
