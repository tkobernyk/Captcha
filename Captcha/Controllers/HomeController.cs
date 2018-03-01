using System.Web.Mvc;
using CaptchaMvc.Attributes;
using CaptchaMvc.HtmlHelpers;

namespace Captcha.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [CaptchaVerify("Captcha is not valid")]
        public ActionResult Index(string id)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.ErrMessage = "Error: captcha is not valid.";
            }
            return View();
        }
    }
}