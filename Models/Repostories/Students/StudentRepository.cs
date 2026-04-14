
using WebApiStudent.Controllers;
using WebApiStudent.Data;

namespace WebApiStudent.Models.Repostories.Students
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentContext _studentContext;

        public StudentRepository(StudentContext studentContext)
        {
            _studentContext = studentContext;

        }
        public List<Student> GetAll()
        {
             
            return _studentContext.Students.ToList();
        }
    }
}
