using StudentsAndTeachers.Interfaces;
using StudentsAndTeachers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsAndTeachers.Repositories
{
    public class ClassesRepository : IClassesRepository
    {
        private readonly AppDbContext _appDbContext;
        public ClassesRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void AddClass(ClassCourse classCourse)
        { 
            _appDbContext.Classes.Add(classCourse);
            _appDbContext.SaveChanges();
        }


    
        public IEnumerable<ClassCourse> Classes => _appDbContext.Classes;
    }
    
       
}
    

