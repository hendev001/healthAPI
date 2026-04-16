using healthAPI.DTOs;
using healthAPI.Models;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace healthAPI.Repositories
{
    public class StudentRepository :IStudentRepository
    {
        // This is where you would typically inject your database context and implement the methods defined in the IStudentRepository interface.
        private readonly ApplicationDbContext _context;
        public StudentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public string AddStudent(StudentDto student)
        {
            _context.Students.Add(new Student
            {
                StudentName = student.StudentName,
                DOB = student.DOB,
                City = student.City,
                State = student.State,
                Email = student.Email,
                SSN = student.SSN
            });

            _context.SaveChanges();
            return "Student Added successfully";
        }

        public void DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAllStudents()
        {
            // This is a placeholder implementation. You would replace this with actual database retrieval logic.
            return _context.Students.ToList();
        }

        public Student? GetStudentById(int id)
        {
            throw new NotImplementedException();
        }

        public Student GetStudentByName(string name)
        {
            throw new NotImplementedException();
        }

        public void UpdateStudent(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
