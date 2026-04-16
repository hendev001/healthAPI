using healthAPI.Models;

namespace healthAPI.Repositories
{
    public interface IStudentRepository
    {

        List<Student> GetAllStudents();
    }
}
