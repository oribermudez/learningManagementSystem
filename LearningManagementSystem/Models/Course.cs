using LearningManagementSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.Models
{
    public partial class Course
    {
        //constructor
        public int Id { get; set; }
        public string Name { get; set; }
        public string Instructor { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }




        public Course(int id, string name, string instructor, DateTime startDate, DateTime endDate)
        {
            Id = id;
            Name = name;
            Instructor = instructor;
            StartDate = startDate;
            EndDate = endDate;
        }

        //public void DeleteCourse(int id)
        //{
        //    int courseToDelete = id;

        //    //loop through the list to find the id

        //}

        public void UpdateCourse(int id, string name, string instructor)
        {
            if (string.IsNullOrEmpty(name))
            {
                //need to implement an exception
                throw new NotImplementedException();
            }

            //define found boolean to false 
            //bool found = false;

            ////loop through list
            //for (int i = 0; i < _courses.Count - 1; i++)
            //{
            //    //check if current course Id matches id argument
            //    if (_courses[i].Id == id)
            //    {
            //        //assign name argument to NAME PROPERTY for course
            //        _courses[i].Name = name;

            //        //assign name instructor to Instructor PROPERTY for course
            //        _courses[i].Instructor = instructor;

            //        //assigned found to true
            //        found = true; break;
            //    }

            //    if (found == false)
            //    {
            //        //need to implement an exception
            //        throw new NotImplementedException();
            //    }
            //}
        }

        //public Course ViewCourse(string name)
        //{
        //    //loop through the list to find the name
        //    foreach (var course in _courses)
        //    {
        //        //check current course matches name argument
        //        if (course.Name == name)
        //        {
        //            return course;
        //        }
        //    }
        //    //return null if it wasnt in the list
        //    return null;
        //}
    }
}
