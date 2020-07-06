using StudentsAndTeachers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsAndTeachers.Interfaces
{
    public interface IHomeworkRepository
    {
        void AddHomework(Homework homework);
    }
}
