using System.Collections;
using System.Collections.Generic;

namespace StudentsAndTeachers.Models
{
    public class ClassCourse
    {
        public int id { get; set; }
        public string name { get; set; }
        public IList<Homework> Homeworks { get; set; }
        public IList<StreamMessage> Messages { get; set;} 
    }
}