using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    
   
    public class Index1Model : PageModel
    {
        [BindProperty]
        public string FirstName { get; set; }
        public void OnGet()
        {
            FirstName = "ROSHAN";
        }
        public void OnPost()
        {
            if (String.IsNullOrWhiteSpace(FirstName))
            {
                ViewData["NoName"] = "You havenot entered a name";
            }


        }
    }
}
