using StudentsAndTeachers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsAndTeachers.ViewModels
{
    public class CourseListViewModel
    {
        public IList<ClassCourse> ClassCourses { get; set; }
    }
}
