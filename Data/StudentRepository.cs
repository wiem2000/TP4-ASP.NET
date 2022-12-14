using tp4asp.Models;

namespace tp4asp.Data
{
    public class StudentRepository :Repository<Student> , IStudentRepository
    {
        private readonly UniversityContext context;

        public StudentRepository(UniversityContext c):base(c)
        {
            this.context = c;
        }

        public IEnumerable<string?> GetCourses()
        {
            return context.Student.Select(s => s.course).Distinct().ToList();
        }


        public IEnumerable<Student> GetStudentsByCourse(string course)
        {
            IEnumerable<Student> t = context.Student.Where(s => s.course.ToUpper() == course.ToUpper()).ToList();
            return t;
        }

    } 
}
