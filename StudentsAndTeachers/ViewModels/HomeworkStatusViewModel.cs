using StudentsAndTeachers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsAndTeachers.ViewModels
{
    public class HomeworkStatusViewModel
    {
        public IList<Homework> homeworks { get; set; }
    }
}
