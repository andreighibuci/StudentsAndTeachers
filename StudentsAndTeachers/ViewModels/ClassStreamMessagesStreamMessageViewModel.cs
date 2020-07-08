using StudentsAndTeachers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsAndTeachers.ViewModels
{
    public class ClassStreamMessagesStreamMessageViewModel
    {
        public StreamMessage streamMessage { get; set; }
        public ClassCourse course { get; set; }

        public IList<StreamMessage> streamMessages { get; set; }
    }
}
