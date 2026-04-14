using Microsoft.EntityFrameworkCore;
using WebApiStudent.Models;

namespace WebApiStudent.Data;

public class StudentContext:DbContext
{

    public StudentContext(DbContextOptions option):base(option)
    {

    }
    public DbSet<Student> Students { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<State> States { get; set; }
    public DbSet<City> Cities { get; set; }
}
