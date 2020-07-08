using StudentsAndTeachers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsAndTeachers.ViewModels
{
    public class ClassHomeworkViewModel
    {
        public IList<Homework> Homeworks { get; set; }
        public ClassCourse classCourse { get; set; }
    }
}
