using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.Exceptions
{
    internal class CannotPopulateListException : Exception
    {
        public CannotPopulateListException() : base("Cannot populate the student list.") { }
    }
}
