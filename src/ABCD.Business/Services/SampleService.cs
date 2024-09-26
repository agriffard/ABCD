namespace ABCD.Business.Services;

public partial class SampleService : ISampleService
{
    private readonly ISampleRepository _sampleRepository;

    public SampleService(ISampleRepository sampleRepository)
    {
        _sampleRepository = sampleRepository;
    }
}
