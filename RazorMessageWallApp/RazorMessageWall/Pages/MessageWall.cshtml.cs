using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorMessageWall.Pages
{
    public class MessageWallModel : PageModel
    {
		[BindProperty]
		public string Message { get; set; }
		public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            return Page();
        }
    }
}
