using Classroom.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classroom.ViewModels
{
    public class SubmittedWorkViewModel
    {
        public IList<AssignmentSubmit> assignmentSubmits { get; set; }
        public UserManager<IdentityUser> UserManager { get; set; }
       
    }
}
