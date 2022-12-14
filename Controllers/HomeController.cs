using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using tp4asp.Data;
using tp4asp.Models;

namespace tp4asp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()

        {
            UniversityContext u1 = UniversityContext.Instance();

            UniversityContext u2 = UniversityContext.Instance();

            if (u1 == u2)
            {
                System.Diagnostics.Debug.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Singleton failed, variables contain different instances.");
            }


            UniversityContext u = UniversityContext.Instance();
            List<Student> students = u.Student.ToList();

            foreach (var student in students)
            {
                System.Diagnostics.Debug.WriteLine(" id "+student.id+ " first name "
                    +student.first_name+ " last name "+student.last_name 
                    + " phone number " + student.phone_number + " university " + student.university + " course " 
                    + student.course + " timestamp " + student.timestamp);
            }
           
           

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