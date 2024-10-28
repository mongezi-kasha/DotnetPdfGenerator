using DotnetPdfGenerator.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PuppeteerSharp;
using System.Runtime.InteropServices;
using System.Text.Json;

namespace DotnetPdfGenerator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChurchMembersController : ControllerBase
    {
        [HttpPost("get-report")]

        public async Task<IActionResult> GetChurchReport(IEnumerable<ChurchMembers> churchMembers)
        {
            var options = new LaunchOptions
            {
                Headless = true,
            };

            var browser = new BrowserFetcher();
            await browser.DownloadAsync();

            using var browse = await Puppeteer.LaunchAsync(options);
            using var page = await browse.NewPageAsync();
            using var memoryStream = new MemoryStream();

            var url = Url.ActionLink("Index", "PdfGenerator", new {model = JsonSerializer.Serialize(churchMembers)});
            await page.GoToAsync(url);

            var pdfstream = await page.PdfDataAsync();

            return File(pdfstream, "application/pdf", "churchMembers.pdf");
        }
    }
}
