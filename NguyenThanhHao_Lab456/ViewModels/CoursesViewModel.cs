using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NguyenThanhHao_Lab456.Models;

namespace NguyenThanhHao_Lab456.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Following> Followings { get; set; }
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}