using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class XOKADbContextFactory : DesignTimeDbContextFactoryBase<XOKADbContext>
    {
        protected override XOKADbContext CreateNewInstance(DbContextOptions<XOKADbContext> options)
        {
            return new XOKADbContext(options);
        }
    }
}
