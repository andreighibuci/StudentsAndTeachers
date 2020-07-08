using System;
using System.Collections.Generic;

namespace StudentsAndTeachers.Models
{
    public class StreamMessage
    {
        public int id { get; set; }
        public string message { get; set; }
        public ClassCourse classCourse { get; set; }
        public List<Comment> Comments { get;set; }
        public DateTime dateTime { get; set; }
    }
}