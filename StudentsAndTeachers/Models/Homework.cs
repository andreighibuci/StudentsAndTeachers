using System;
using System.Collections.Generic;

namespace StudentsAndTeachers.Models
{
    public class Homework
    {
        public int id { get; set; }
        public string name { get; set; }
        public int grade { get; set; }
        public DateTime deadline{ get; set; }
        public List<Comment> Comments { get; set; }
    }
}