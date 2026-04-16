using healthAPI.DTOs;
using healthAPI.Models;

namespace healthAPI.Repositories
{
    public interface IStudentRepository
    {

        List<Student> GetAllStudents();

        Student? GetStudentById(int id);

        Student GetStudentByName(string name);

        // string AddStudent(StudentDto student);

        List<Student> AddStudents(List<StudentDto> students);
        void UpdateStudent(Student student);

        void DeleteStudent(int id);
    }
}
