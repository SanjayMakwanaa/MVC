using CrudApp.Models;
using System.Collections.Generic;

namespace CrudApp.Models
{
    public interface IStudentRepository
    {
        IEnumerable<Student> Students { get; }

        int SaveStudent(Student student);

        Student  DeleteStudent(int Id);

    }
}
