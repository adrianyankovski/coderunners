using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages.Shared
{
	public class ContactModel : PageModel
	{
		public bool hasData = false;
		public string firstName = "";
		public string lastName = "";
		public string message = "";
		public void OnGet()
		{

		}

		public void OnPost()
		{
			hasData = true;
			firstName = Request.Form["firstname"];
			lastName = Request.Form["Lastname"];
			message = Request.Form["message"];
		}
	}
}
