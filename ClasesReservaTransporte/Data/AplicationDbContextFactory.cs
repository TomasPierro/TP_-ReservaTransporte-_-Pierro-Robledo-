using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ClasesReservaTransporte.Data
{
    public class AplicationDbContextFactory
        : IDesignTimeDbContextFactory<AplicationDbContext>
    {
        public AplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AplicationDbContext>();

            optionsBuilder.UseSqlite(@"Data Source=C:\DATABASE\DATABASE.db");

            return new AplicationDbContext(optionsBuilder.Options);
        }
    }
}