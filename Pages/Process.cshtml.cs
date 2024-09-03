using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace hellorazor.Pages
{
    public class ProcessModel : PageModel
    {
        public void OnGet()
        {
            ViewData["Message"] = "This is the first day of the fall term";

            string[] people = { "John", "Jane", "Jill" };
            ViewData["people"] = people;

        }
    }
}
