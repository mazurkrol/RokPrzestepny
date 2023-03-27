using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RokPrzestepny.Forms;
using System.ComponentModel.DataAnnotations;

namespace RokPrzestepny.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;
		[BindProperty]
		public SpecialYear FizzBuzz { get; set; }
		public IndexModel(ILogger<IndexModel> logger)
		{
			_logger = logger;
		}

		public void OnGet()
		{

		}
		public IActionResult OnPost()
		{
			if (FizzBuzz != null)
			{
				ViewData["Year"]=FizzBuzz.LeapYear();
				ViewData["Filled"]=FizzBuzz.IsGood();
			}
				return Page();
        }
	}
}