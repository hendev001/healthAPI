using healthAPI.DTOs;
using healthAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace healthAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolCrontroller : ControllerBase
    {
        private readonly IStudentRepository studentRepository;
        public SchoolCrontroller(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }


        // api/School/GetAllStudents
        [HttpGet("GetAllStudents")]
        public IActionResult Get()
        {
            var students = studentRepository.GetAllStudents();
            return Ok(students);
        }


        //[HttpGet("{id}")]
        //public IActionResult Get(int id)
        //{
        //    var student = studentRepository.GetStudentById(id);
        //    if (student == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(student);
        //}


        //[HttpPost("AddStudent")]
        //public IActionResult Post([FromBody] StudentDto student)
        //{
        //     var result = studentRepository.AddStudent(student);
        //    if (result == null)
        //        {
        //        return BadRequest("Failed to add student.");
        //    }       
        //    return Ok(result);
        //}


        [HttpPost("AddStudents")]
        public IActionResult Post([FromBody] List<StudentDto> students)
        {
            if (students == null || !students.Any())
            {
                return BadRequest("Student list is empty.");
            }

            var result = studentRepository.AddStudents(students);

            if (result == null)
            {
                return BadRequest("Failed to add students.");
            }

            return Ok(result);
        }
    }
}