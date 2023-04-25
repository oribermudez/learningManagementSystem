using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.Exceptions
{
    internal class CannotDeleteStudentException : Exception
    {
        public CannotDeleteStudentException() : base("Cannot delete the student from the database.") { }
    }
}
