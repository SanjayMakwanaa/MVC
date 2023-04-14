using CrudApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using SportsStore.Models;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace CrudApp.Models
{
    public class EFStudentRepository : IStudentRepository
    {
        private ApplicationDbContext context;
        public EFStudentRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IEnumerable<Student> Students => context.Students;


        public int SaveStudent(Student student)
        {
            int i;
            if (student.StudentID == 0)
            {
                context.Students.Add(student);
                
            }
            else
            {
                Student dbEntry = context.Students.FirstOrDefault(p => p.StudentID == student.StudentID);
                if (dbEntry != null)
                {
                    
                    dbEntry.Name = student.Name;
                    dbEntry.Email = student.Email;
                    dbEntry.City = student.City;
                }
            }
            i=context.SaveChanges();
            return i;
        }
        public Student DeleteStudent(int Id)
        {
            Student dbEntry = context.Students.FirstOrDefault(p => p.StudentID == Id);

            if (dbEntry != null)
            {
                context.Students.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}