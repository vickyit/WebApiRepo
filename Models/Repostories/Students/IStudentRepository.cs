using WebApiStudent.Models.Dtos.Students;

namespace WebApiStudent.Models.Repostories.Students;

public interface IStudentRepository
{
    public List<Student> GetAll();
    public void Add(CreateUpdateStudentDto input);
}
