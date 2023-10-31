using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using movies_app.Models;
using movies_app.Services; // Replace YourNamespace.Services with your actual namespace
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace movies_app.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApiService _apiService; // Adding the ApiService

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _apiService = new ApiService(); // Initializing the ApiService
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                var data = await _apiService.GetPopularMovies();

                // Deserialize the data into the Root object
                var model = JsonConvert.DeserializeObject<Root>(data);

                return View(model);
            }
            catch (HttpRequestException ex)
            {
                // Log the exception or perform any other error handling
                Console.WriteLine($"An HTTP request exception occurred: {ex.Message}");
                return View("Error"); // Return an error view
            }
            catch (Exception ex)
            {
                // Handle any other exceptions that might occur
                Console.WriteLine($"An unexpected exception occurred: {ex.Message}");
                return View("Error"); // Return an error view
            }
        }

        public IActionResult Watchlist()
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
