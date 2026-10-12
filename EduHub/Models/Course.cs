using System;
using System.Collections.Generic;
using System.Text;

namespace EduHub.Models
{
    public class Course
    {
        public string CourseId { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public Course(string courseId, string title, int credits)
        {
            CourseId = courseId;
            Title = title;
            Credits = credits;
        }
    }
}
