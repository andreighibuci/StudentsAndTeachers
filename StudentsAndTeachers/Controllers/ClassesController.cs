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
            
            return View(classCourse);
        }

        public IActionResult NewClassCreator(ClassCourse classCourse)
        {
            _classesRepository.AddClass(classCourse);
            IList<ClassCourse> classCourses = new List<ClassCourse>();
            foreach (ClassCourse classCourse1 in _appDbContext.Classes)
            {
                classCourses.Add(classCourse1);
            }

            var classCoursesVM = new CourseListViewModel()
            {
                ClassCourses = classCourses
            };
            return View("~/Views/Classes/ListOfClasses.cshtml",classCoursesVM);
        }

        public ViewResult Class(int courseId)
        {
            var course = _classesRepository.Classes.FirstOrDefault(d => d.id == courseId);
            if(course == null)
            {
                return View("~/Views/Home/Index.cshtml");
            }
            return View(course);
        }
    }
}