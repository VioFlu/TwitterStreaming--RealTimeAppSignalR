using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Diagnostics;
using System.Threading.Tasks;
using TwitterStreaming.Models;
using TwitterStreaming.Services;

namespace TwitterStreaming.Controllers
{
    public class HomeController : Controller
    {
        private readonly TwitterService _twitterService;

        public HomeController(TwitterService twitterService, IConfiguration configuration)
        {
            _twitterService = twitterService;
            _twitterService.consumerKey = configuration["TwitterKeys:consumerKey"];
            _twitterService.consumerSecretKey = configuration["TwitterKeys:consumerSecretKey"];
        }
        public async Task<IActionResult> Index()
        {
            return View();
        }

        public IActionResult About()
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
    }
}
