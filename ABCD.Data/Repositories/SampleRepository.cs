namespace ABCD.Data.Repositories;

public partial class SampleRepository : ABCDRepository<Sample, int>, ISampleRepository
{
    public SampleRepository(ILogger<SampleRepository> logger, IDbContextFactory<ABCDContext> contextFactory) : base(logger, contextFactory)
    {
    }
}
