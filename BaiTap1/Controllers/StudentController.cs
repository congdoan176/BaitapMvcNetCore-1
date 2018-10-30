using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaiTap1.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiTap1.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentContext _context;
        public StudentController(StudentContext context)
        {
            _context = context;
        }
        public IActionResult Create()
        {
            return View();
        }
        
        public IActionResult Student()
        {
            var obj = _context.Students.ToList();
            return View(obj);
            //return new JsonResult(_context.Students.ToList());
        }
        [HttpPost]
        public IActionResult Store(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            TempData["Message"] = "Add success";
            return Redirect("Student");
        }
        public IActionResult Edit(long id)
        {
            var obj = _context.Students.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        public IActionResult Update(Student student)
        {
            var obj = _context.Students.Find(student.Id);
            if(obj == null)
            {
                return NoContent();
            }
            
            obj.Name = student.Name;
            obj.RollNumber = student.RollNumber;

            _context.Students.Update(obj);
            _context.SaveChanges();
            return Redirect("Student");
            
        }
        [HttpDelete]
        public IActionResult Delete(long id)
        {
            var obj = _context.Students.Find(id);
            if (obj == null)
            {
                return NoContent();
            }
            _context.Students.Remove(obj);
            _context.SaveChanges();
            return Json(obj);
        }
    }
}