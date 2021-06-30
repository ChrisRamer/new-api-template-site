using Microsoft.AspNetCore.Mvc;

namespace CretaceousClient.Controllers
{
	public class HomeController : Controller
	{
		[HttpGet("/")]
		public ActionResult Index()
		{
			return View();
		}
	}
}