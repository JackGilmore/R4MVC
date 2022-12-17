namespace AspNetSimple.Controllers;

[Authorize, RequireHttps]
public partial class SecureController : Controller
{
    public virtual IActionResult Index() => throw new NotImplementedException();
}
