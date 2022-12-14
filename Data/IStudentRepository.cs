using tp4asp.Models;

namespace tp4asp.Data
{
    public interface IStudentRepository:IRepository<Student>
    {
       
        IEnumerable<string?> GetCourses();
        IEnumerable<Student> GetStudentsByCourse(string course);
       
      
    }
}
