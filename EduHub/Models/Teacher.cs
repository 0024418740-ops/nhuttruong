using System;
using System.Collections.Generic;
using System.Text;

namespace EduHub.Models
{
    public class Teacher : User
    {
        public string Major { get; set; }

        public Teacher(string id, string name, string email, string major)
            : base(id, name, email)
        {
            Major = major;
        }
    }
}
