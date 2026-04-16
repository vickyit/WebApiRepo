using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiStudent.Models;
using WebApiStudent.Models.Dis;
using WebApiStudent.Models.Dtos.Students;
using WebApiStudent.Models.Repostories.Students;

namespace WebApiStudent.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {

        private readonly IStudentRepository _studentRepository;

        public TestController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;

        }

        [HttpPost]
        public void Post(CreateUpdateStudentDto input)
        {
            _studentRepository.Add(input);
        }

        [HttpGet]
        public List<Student> Get()
        {
            return _studentRepository.GetAll();
        }

        //localhost:7050/api/test/1110/100
        //localhost:7050/100/10

        //[HttpGet("/{value1}/{value2}")]
        [HttpGet("fix/{value1}/{value2}")]

        //public int Get(int value1, int value2)
       // public ActionResult<int> Get(int value1, int value2)
        public IActionResult Get(int value1, int value2)

        {
            try
            {

                var result = value1 / value2;

                var values = new int[3] { 1, 2, 3 };

                Console.WriteLine(values[4]);

                //return "ram";
                //return result;
               
                return Ok(result);
                  


            }
            catch(DivideByZeroException ex)
            {

                return BadRequest("1st "+ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                return BadRequest("2nd " + ex.Message);
            }

            catch (Exception ex)
            {
                return BadRequest("3rd "+ex.Message);

            }
            finally
            {

                Console.WriteLine("Finally");
            }
        }
    }
}
