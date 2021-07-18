using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bigschool1.Models;

namespace Bigschool1.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcomingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}