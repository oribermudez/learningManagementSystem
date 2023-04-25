using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.Exceptions
{
    internal class CannotAddStudentException : Exception
    {
        public CannotAddStudentException() : base("Cannot add the student to the database.") { }
    }
}
