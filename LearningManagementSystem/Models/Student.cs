using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.Models
{
    public partial class Student : BaseModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Program { get; set; }
        public double Phone { get; set; }
        public string Email { get; set; }

        public Student(int id, string firstName, string lastName, string program, double phone, string email)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Program = program;
            Phone = phone;
            Email = email;
        }

        public Student()
        {
        }
    }
}
