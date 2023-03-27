using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RokPrzestepny.Forms;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace RokPrzestepny.Pages
{
    
    public class ZapisaneModel : PageModel
    {
        public SpecialYear YearPassed { get; set; }
        public void OnGet()
        {
            var Data = HttpContext.Session.GetString("Data");
            if (Data != null)
                YearPassed =JsonConvert.DeserializeObject<SpecialYear>(Data);
        }
    }
}
