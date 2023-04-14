using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CrudApp.Models
{
    public class Student
    {
        internal List<Student> studentList;

        [Key]
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
    }
}
