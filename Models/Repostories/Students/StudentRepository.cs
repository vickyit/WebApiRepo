
using WebApiStudent.Controllers;
using WebApiStudent.Data;
using WebApiStudent.Models.Dtos.Students;

namespace WebApiStudent.Models.Repostories.Students
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentContext _studentContext;

        public StudentRepository(StudentContext studentContext)
        {
            _studentContext = studentContext;

        } 

        public void  Add(CreateUpdateStudentDto input)
        {
            Student student = new Student();
            student.Name = input.Name;


            _studentContext.Students.Add(student);
            _studentContext.SaveChanges();

        }
    }
}
