using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string FirstName { get; set; }
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            FirstName = "Roshan";
        }
        public void OnPost()
        {
            if(String.IsNullOrWhiteSpace(FirstName))
            {
                ViewData["NoName"] = "You havenot entered a name";
            }

        }

    }
}