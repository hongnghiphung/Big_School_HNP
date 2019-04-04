using Big_School_HNP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Big_School_HNP.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcomingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}