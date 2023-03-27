using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RokPrzestepny.Forms;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Collections.Specialized;

namespace RokPrzestepny.Pages
{
	public class IndexModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;
		[BindProperty]
		public SpecialYear FizzBuzz { get; set; }
		public SessionTransporter SessionTrans = new SessionTransporter();
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
				if (FizzBuzz.IsGood())
				{
                    var Data = HttpContext.Session.GetString("Current");
                    if (Data != null)
                    {
                        SessionTrans =JsonConvert.DeserializeObject<SessionTransporter>(Data);
                    }
                    SessionTrans.Adder(FizzBuzz);
					HttpContext.Session.SetString("Data", JsonConvert.SerializeObject(SessionTrans));
					HttpContext.Session.SetString("Current", JsonConvert.SerializeObject(SessionTrans));
				}
            }
				return Page();
        }
	}
}