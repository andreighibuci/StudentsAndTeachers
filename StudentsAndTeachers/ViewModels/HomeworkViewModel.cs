using StudentsAndTeachers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsAndTeachers.ViewModels
{
    public class HomeworkViewModel
    {
        public Homework homework { get; set; }
        public ClassCourse course{ get; set; }
    }
}
