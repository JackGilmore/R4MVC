namespace AspNetSimple.Pages;

public partial class DefaultModel : PageModel
{
    public virtual IActionResult OnGet()
    {
        return Page();
    }

    public virtual void OnPost(int id)
    {
    }

    public virtual void OnPostTest(int id)
    {
    }

    public virtual Task OnPostDeleteAsync()
    {
        return Task.CompletedTask;
    }
}
