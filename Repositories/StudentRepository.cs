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

        public List<Student> GetAllStudents()
        {
            // This is a placeholder implementation. You would replace this with actual database retrieval logic.
            return _context.Students.ToList();
        }
    }
}
