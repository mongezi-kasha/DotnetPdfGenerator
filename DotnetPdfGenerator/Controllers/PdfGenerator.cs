using DotnetPdfGenerator.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotnetPdfGenerator.Controllers
{
    public class PdfGenerator : Controller
    {
        public IActionResult Index()
        {
            var Ypddepartment = new ChurchDepartments
            {
                Name = "YPD"
            };

            var umanyamoDepartment = new ChurchDepartments
            {
                Name = "Umanyano lomama"
            };
            var youthChoir = new ChurchDepartments
            {
                Name = "Choir"
            };

            var churchMembers = new List<ChurchMembers>
            {
                new ChurchMembers
                {
                    MemberId = 1,
                    FirstName = "Sive",
                    LastName = "Manyube",
                    Role = "Drummer",
                    Departments = Ypddepartment
                },

                new ChurchMembers
                {
                    MemberId = 2,
                    FirstName = "Mama u",
                    LastName = "Bheja",
                    Role = "Prayer",
                    Departments = umanyamoDepartment
                },

                new ChurchMembers
                {
                    MemberId = 3,
                    FirstName = "Khanya",
                    LastName = "Nkumanda",
                    Role = "Taking Videos",
                    Departments = youthChoir
                }
            };
            return View(churchMembers);
        }
    }
}
