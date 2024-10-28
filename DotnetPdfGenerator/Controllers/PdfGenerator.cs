using DotnetPdfGenerator.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace DotnetPdfGenerator.Controllers
{
    public class PdfGenerator : Controller
    {
        public IActionResult Index(string model)
        {
            var churchMembers = JsonSerializer.Deserialize<IEnumerable<ChurchMembers>>(model);
            return View(churchMembers);
        }
    }
}
