using CrudApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportsStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Xml.Linq;

namespace CrudApp.Controllers
{

    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IStudentRepository _repository;

        public StudentController(ApplicationDbContext context, IStudentRepository repository)
        {
            _context = context;
            _repository = repository;
        }

        #region Load_View_Data
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult LoadData()
        {
            var students = _context.Students.ToList();
            return Json(new { data = students });
        }
        #endregion

        #region Delete_Student
        [HttpPost]
        public IActionResult Delete(int studentID)
        {
            Student deleteStudent = _repository.DeleteStudent(studentID);
            if (deleteStudent != null)
            {
                return Json(new { success = true });
            }
            else
            {
                return Json(new { success = false, error = "Failed to delete student" });
            }
        }
        #endregion

        #region Create_Student
        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _repository.SaveStudent(student);
 
                return new JsonResult(new { status = true, message = "Saved" });
            }
            else
            {
                return new JsonResult(new { status = false, message = "Failed" });
            }

        }
        #endregion

        #region Edit_Student
        public ViewResult Edit(int Id)
        {
            return View(_repository.Students.FirstOrDefault(p => p.StudentID == Id));
        }

        public ViewResult GetStudentById(int Id)
        {
            return View(_repository.Students.FirstOrDefault(p => p.StudentID == Id));
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                _repository.SaveStudent(student);


                return new JsonResult(new {status = true, message = "Saved"});
            }
            else
            {
               
                return RedirectToAction("Index");
            }

        }
        #endregion
    }
}
