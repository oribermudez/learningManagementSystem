using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem
{
    internal class DB
    {

        public List<Course> GetCourses()
        {
            // SELECT courses from DB

            // Loop through records/rows

            // Get column data

            // Create new Course instance/object/model from column data
            Course objectOrientedProgramming = new Course(101, "OOP2", "Nick", new DateTime(2023, 01, 09), new DateTime(2023, 04, 25));

            // Add new Course instance to List
        }
    }
}
