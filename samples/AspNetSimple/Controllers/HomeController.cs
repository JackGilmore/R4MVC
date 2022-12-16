namespace AspNetSimple.Controllers;

public partial class HomeController : Controller
{
    public virtual IActionResult Index()
    {
        return View();
    }

    public virtual IActionResult About()
    {
        ViewData["Message"] = "Your application description page.";

        return View();
    }

    public virtual IActionResult Contact()
    {
        ViewData["Message"] = "Your contact page.";

        return View();
    }

    public virtual IActionResult Error([Bind(Prefix = "errorCode")] int statusCode = 500)
    {
        var model = new ErrorViewModel
        {
            StatusCode = statusCode,
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier,
        };

        return View(model);
    }
}
