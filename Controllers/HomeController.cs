using ASP.netMay23.Models;
using Microsoft.AspNetCore.Mvc;
// cookies library
using System.Diagnostics;

namespace ASP.netMay23.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly maydbContext _context;
        //cookies usage
        private readonly IHttpContextAccessor _contextAccessor;
        CookieOptions _cookie = new CookieOptions();
        public HomeController(ILogger<HomeController> logger, maydbContext context, IHttpContextAccessor contextAccessor, CookieOptions cookie)
        {
            _logger = logger;
            _context = context;
            _cookie = cookie;
            _contextAccessor = contextAccessor;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult Create()
        {
            //for cookies
            var username = "Theta";
            var password = "Students";

            _contextAccessor.HttpContext.Response.Cookies.Append("Username", username);

            var cookiename = HttpContext.Request.Cookies["Username"];
            //_contextAccessor.HttpContext.Response.Cookies.Delete(cookiename);
            _cookie.Expires = DateTime.Now.AddMonths(1);
            return View();
        }
    }
}