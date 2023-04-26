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
    internal class CannotUpdateStudentException : Exception
    {
        public CannotUpdateStudentException() : base("Cannot update student.") { }
    }
}
