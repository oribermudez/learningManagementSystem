using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.Interfaces
{
    internal interface ICourse
    {
        //methods:
        //public Course CreateCourse(int id, string name, string instructor, DateTime startDate, DateTime endDate);

        Course ViewCourse(string name);


        void UpdateCourse(int id, string name, string instructor);

        //void DeleteCourse();
    }
}
