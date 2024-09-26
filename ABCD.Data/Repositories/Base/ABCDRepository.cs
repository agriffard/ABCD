//using Divotiz.Common.Core.Interfaces.Entities;

namespace ABCD.Data.Repositories.Base;

public class ABCDRepository<T, TId> : IABCDRepository<T, TId>
{
    private readonly IDbContextFactory<ABCDContext> _contextFactory;
    private readonly ABCDContext _context;

    //public ABCDRepository(ILogger<ABCDRepository<T, TId>> logger, ABCDContext context) : base(logger, context)
    //{
    //}

    public ABCDRepository(ILogger<ABCDRepository<T, TId>> logger, IDbContextFactory<ABCDContext> contextFactory) // : base(_logger, contextFactory)
    {
    }
}
