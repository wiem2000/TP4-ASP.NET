using Microsoft.AspNetCore.Mvc;
using tp4asp.Data;
using tp4asp.Models;

namespace tp4asp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult all()
        {

            UnitOfWork u = new UnitOfWork(UniversityContext.Instance());

            var list = u.Students.GetAll();

            return View("studentsCourse", list);
        }
        public IActionResult Courses()
        {
            UnitOfWork u = new UnitOfWork(UniversityContext.Instance());

            var list = u.Students.GetCourses();

            return View("courses",list);
        }
        public IActionResult Course(string course)
        {
            UnitOfWork u = new UnitOfWork(UniversityContext.Instance());

            IEnumerable<Student> list = u.Students.GetStudentsByCourse(course);

            return View("studentsCourse", list);
        }
        public IActionResult Detail(int id)
        {
            UnitOfWork u = new UnitOfWork(UniversityContext.Instance());

            Student? student = u.Students.GetById(id);

            return View("studentsDetail", student);
        }
    }

}
