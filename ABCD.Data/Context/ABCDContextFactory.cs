using Microsoft.EntityFrameworkCore.Design;

namespace ABCD.Data.Context;
public class ABCDContextFactory : IDesignTimeDbContextFactory<ABCDContext>
{
    public ABCDContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ABCDContext>();
        optionsBuilder.UseSqlServer(@"Server=.\SQLExpress;Database=ABCD;Trusted_Connection=True;TrustServerCertificate=True");

        var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());

        return new ABCDContext(optionsBuilder.Options, loggerFactory);
    }
}
