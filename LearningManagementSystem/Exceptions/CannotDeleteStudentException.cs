using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.Exceptions
{
    /// <summary>
    /// Exception
    /// </summary>
    /// <remarks> Authors: Matthew Yackel, Ana Alarcon, Oriana Bermudez </remarks>
    /// <remarks> Date: Apr 25, 2023 </remarks>
    internal class CannotDeleteStudentException : Exception
    {
        public CannotDeleteStudentException() : base("Cannot delete the student from the database.") { }
    }
}
