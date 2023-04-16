using Microsoft.AspNetCore.Mvc;

namespace ExternalLogin.Controllers
{
    [Route("signin-google")]
    public class GoogleController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
