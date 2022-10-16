using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages

{
    public class CurrencyConverterModel : PageModel
    {
        [BindProperty]
        public string Amount { get; set; }
        
        
        private const double RATE = 1.14;

        public void OnGet()
        {
        }
        double result;

        public void OnPost()
        {
            // Display Result in case the user has clicked the Convert button
            if (!String.IsNullOrEmpty(Amount))
            {
                result = Convert.ToDouble(Amount) * RATE;
                ViewData["Message"] = $"{Amount} GBP is {result.ToString("0.00")} USD";
            }
        }
}


}
