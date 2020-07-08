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
        private readonly IHomeworkRepository _homeworkRepository;
        private readonly IStreamMessageRepository _streamMessageRepository;
        public ClassesController(AppDbContext appDbContext, IClassesRepository classesRepository, IHomeworkRepository homeworkRepository, IStreamMessageRepository streamMessageRepository)
        {
            _appDbContext = appDbContext;
            _classesRepository = classesRepository;
            _homeworkRepository = homeworkRepository;
            _streamMessageRepository = streamMessageRepository;
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

        public ViewResult Class(int courseId,StreamMessage streamMessage1)
        {
            IList<StreamMessage> streamMessages = new List<StreamMessage>();
            var course = _classesRepository.Classes.FirstOrDefault(d => d.id == courseId);
            if(course == null)
            {
                return View("~/Views/Home/Index.cshtml");
            }

            foreach (StreamMessage streamMessage in _appDbContext.StreamMessages)
            {
                streamMessages.Add(streamMessage);
            }

            var ClassStreamMessagesStreamMessageVM = new ClassStreamMessagesStreamMessageViewModel
            {
                course = course,
                streamMessage = streamMessage1,
                streamMessages = streamMessages
            };

            return View(ClassStreamMessagesStreamMessageVM);
        }
        public IActionResult CreateHomeworkView(int courseId, HomeworkViewModel homework)
        {
            var course = _classesRepository.Classes.FirstOrDefault(d => d.id == courseId);
            homework.course = course;
            return View(homework);
        }
        public IActionResult CreateHomework(int courseId, Homework homework)
        {
            var course = _classesRepository.Classes.FirstOrDefault(d => d.id == courseId);
            if (course == null)
            {
                return View("~/Views/Home/Index.cshtml");
            }
            
            var HomeworkModel = new HomeworkViewModel()
            {
                homework = homework,
                course = course

            };
            HomeworkModel.homework.classCourse = course;
            _homeworkRepository.AddHomework(HomeworkModel.homework);

            return View("~/Views/Classes/Class.cshtml",HomeworkModel.course);
        }
        public IActionResult StatusHomeworks(int courseId)
        {
            var course = _classesRepository.Classes.FirstOrDefault(d => d.id == courseId);
            IList<Homework> homeworks = new List<Homework>();
            foreach(Homework homework in _appDbContext.Homeworks)
            {
                if (course == homework.classCourse)
                {
                    homeworks.Add(homework);
                    
                   
                }
            }

            var HomeworkStatusViewModel = new HomeworkStatusViewModel()
            {
                homeworks = homeworks
            };

            return View(HomeworkStatusViewModel);
        }

        public IActionResult CreateMessage(int courseId, StreamMessage streamMessage)
        {
            IList<StreamMessage> streamMessages = new List<StreamMessage>();
            var course = _classesRepository.Classes.FirstOrDefault(d => d.id == courseId);
            if (course == null)
            {
                return View("~/Views/Home/Index.cshtml");
            }

            var StreamMessageModel = new StreamMessageViewModel
            {
                streamMessage = streamMessage,
                course = course
            };
            StreamMessageModel.streamMessage.classCourse = course;
            StreamMessageModel.streamMessage.dateTime = DateTime.Now;
            _streamMessageRepository.AddMessage(StreamMessageModel.streamMessage);

            foreach (StreamMessage streamMessage1 in _appDbContext.StreamMessages)
            {
                streamMessages.Add(streamMessage1);
            }

            var ClassStreamMessagesStreamMessageVM = new ClassStreamMessagesStreamMessageViewModel
            {
                course = course,
                streamMessage = streamMessage,
                streamMessages = streamMessages
            };
            return View("~/Views/Classes/Class.cshtml", ClassStreamMessagesStreamMessageVM);
        }
    }

   
}