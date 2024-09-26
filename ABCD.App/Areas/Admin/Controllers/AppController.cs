namespace ABCD.Admin.Controllers;

public class AppController : BaseController
{
    private readonly AppSettings _settings;
    private ILogger<AppController> _logger { get; set; }

    public AppController(IOptions<AppSettings> settings, ILogger<AppController> logger)
    {
        _settings = settings.Value;
        _logger = logger;
    }

    public ActionResult Index()
    {
        return View();
    }

    public AppSettings Settings() => _settings;
}
