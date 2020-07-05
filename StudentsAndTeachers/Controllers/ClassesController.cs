using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentsAndTeachers.Interfaces;
using StudentsAndTeachers.Models;
using StudentsAndTeachers.ViewModels;

namespace StudentsAndTeachers.Controllers
{
    public class ClassesController : Controller
    {
        private readonly AppDbContext _appDbContext;
        private readonly IClassesRepository _classesRepository;
        public ClassesController(AppDbContext appDbContext, IClassesRepository classesRepository)
        {
            _appDbContext = appDbContext;
            _classesRepository = classesRepository;
        }
        public IActionResult ListOfClasses()
        {
            IList<ClassCourse> classCourses = new List<ClassCourse>();
            foreach(ClassCourse classCourse in _appDbContext.Classes)
            {
                classCourses.Add(classCourse);
            }

            var classCoursesVM = new CourseListViewModel()
            {
                ClassCourses = classCourses
            };
            return View(classCoursesVM);
        }

        public IActionResult NewClass(ClassCourse classCourse)
        {
            _classesRepository.AddClass(classCourse);
            return View(classCourse);
        }

        public IActionResult Class()
        {
            return View();
        }
    }
}