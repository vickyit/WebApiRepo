using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiStudent.Models;

namespace WebApiStudent.Controllers;

[Route("api/v1/[controller]")]
[ApiController]

public class StudentController : ControllerBase
{
    private readonly StudentAction _student;
     public StudentController()
    {
        _student = new StudentAction();

    }

    [HttpGet]
    public List<Student> Get()
    {
        return _student.List();
     }

    [HttpPost]
    public void Post(string name)
    {
        _student.Create(name);
    }
    [HttpGet("{id}")]
    public Student Get(int id)
    {
        return _student.FindById(id);
    }

    [HttpPut]
    public void Put(Student student)
    {
        _student.Update(student);

    }
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        _student.Delete(id);
    }

}



