using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace LinkGlutton.Mvc.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            using Stream reader = new FileStream("about.json", FileMode.Open, FileAccess.Read);
            Dictionary<string, string> data; data = JsonSerializer.Deserialize<Dictionary<string, string>>(JsonDocument.Parse(reader));

            return View();
        }
    }
}
