using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentsAndTeachers.Interfaces;
using StudentsAndTeachers.Models;

namespace StudentsAndTeachers.Controllers
{
    public class HomeworksController : Controller
    {
        private readonly IHomeworkRepository _homeworkRepository;
        private readonly IClassesRepository _classesRepository;
        private readonly AppDbContext _appDbContext;
        public HomeworksController(IHomeworkRepository homeworkRepository, AppDbContext appDbContext, IClassesRepository classesRepository)
        {
            _homeworkRepository = homeworkRepository;
            _classesRepository = classesRepository;
            _appDbContext = appDbContext;
        }
        public IActionResult Homework(Homework homework)
        {
            return View(homework);
        }

       // public IActionResult CreateHomework(Homework homework)
       // {
        //    _homeworkRepository.AddHomework(homework);
        //    return View("~/Views/Home/Index.cshtml");            
       // }

       /* public IActionResult StatusHomeworks(int classCourseId)
        {
            IList<Homework> homeworks = new List<Homework>();
            for(Homework homework in _appDbContext.Homeworks)
            {
                if(classCourseId == homework.cla)
            }
            return View();
        }
        */

       
    }
}