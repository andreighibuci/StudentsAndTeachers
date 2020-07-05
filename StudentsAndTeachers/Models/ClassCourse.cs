using System.Collections;
using System.Collections.Generic;

namespace StudentsAndTeachers.Models
{
    public class ClassCourse
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Homework> Homeworks { get; set; }
        public List<StreamMessage> Messages { get; set;} 
    }
}