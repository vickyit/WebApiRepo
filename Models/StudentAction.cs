using Microsoft.AspNetCore.Mvc.Formatters;

namespace WebApiStudent.Models;

public class StudentAction
{
    private readonly static List<Student> _students;
    private   static int _id = 3;

    static StudentAction()
    {
        _students = new List<Student>();

        _students.Add(new Student { Id=1, Name = "Sita" });
        _students.Add(new Student { Id=2, Name = "Ram" });
    }

    public void Create(string name)
    {
        var student = new Student();
        student.Name = name;
        student.Id = _id;

        _students.Add(student);
        
        _id = _id + 1;

    }
    public void Update(Student input)
    {
        var student = _students.FirstOrDefault(x =>x.Id == input.Id);

        if (student == null)
        {
            return;
        }
        student.Name = input.Name;

    }
    public void Delete(int id)
    {
        var student = _students.FirstOrDefault(x=>x.Id == id);
        if (student == null)
        {
            return;
        }
        _students.Remove(student);
    }
    public Student FindById(int id)
    {
         return _students.FirstOrDefault(x => x.Id == id);

    }
    public List<Student> List()
    {
        return _students;
    }

}



