namespace ABCD.Data.Context;

public partial class ABCDContext : DbContext
{
    private readonly ILoggerFactory _loggerFactory;

    public ABCDContext(DbContextOptions<ABCDContext> options, ILoggerFactory loggerFactory)
    {
        _loggerFactory = loggerFactory;
    }

    public ABCDContext(DbContextOptions<ABCDContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (_loggerFactory != null)
        {
            optionsBuilder.UseLoggerFactory(_loggerFactory);
        }

        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
}
