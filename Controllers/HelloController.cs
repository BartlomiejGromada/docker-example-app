using docker_api.Data;
using Microsoft.AspNetCore.Mvc;

namespace docker_api.Controllers
{
    [ApiController]
    [Route("hello")]
    public class HelloController : ControllerBase
    {
        private readonly SchoolContext _context;
        public HelloController(SchoolContext context)
        {
            _context = context;
        }

        public IActionResult Hello()
        {
            var student = _context.Students.Where(s => s.Id == 1).FirstOrDefault();
            return Ok($"Hello {student.FirstMidName} {student.LastName}");
        }
    }
}