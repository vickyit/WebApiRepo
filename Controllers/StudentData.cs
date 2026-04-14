using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiStudent.Data;
using WebApiStudent.Models;

namespace WebApiStudent.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentData : ControllerBase
    {
        private readonly StudentContext _context;
        public  StudentData(StudentContext context)
        {
            _context=context;
        }
        [HttpPost]
        public void Post(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();


        }

        [HttpPut]
        public void Put(Student input)
        { 
            var student = _context.Students.Find(input.Id);

            if (student != null)
            {
                student.Name = input.Name;

                _context.Students.Update(student);
                _context.SaveChanges();


            }
        }
        [HttpDelete]
        public void Delete(int id)
        {
            var student = _context.Students.Find(id);
            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }

        }
        [HttpGet]
        public List<Student> Get()
        {
            return _context.Students.ToList();
        }
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return _context.Students.Find(id);
        }

    }
}
