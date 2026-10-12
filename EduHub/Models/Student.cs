using System;
using System.Collections.Generic;
using System.Text;

namespace EduHub.Models
{
    public class Student : User
    {
        public string StudentCode { get; set; }

        public Student(string id, string name, string email, string studentCode)
            : base(id, name, email)
        {
            StudentCode = studentCode;
        }
    }
}
