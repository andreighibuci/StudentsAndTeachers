using StudentsAndTeachers.Interfaces;
using StudentsAndTeachers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsAndTeachers.Repositories
{
    public class HomeworkRepository:IHomeworkRepository
    {
        private readonly AppDbContext _appDbContext;
        public HomeworkRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void AddHomework(Homework homework)
        {
            _appDbContext.Add(homework);
            _appDbContext.SaveChanges();
        }

    }
}
