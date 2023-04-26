using LearningManagementSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.Models
{
    /// <summary>
    /// Course model
    /// </summary>
    /// <remarks> Authors: Matthew Yackel, Ana Alarcon, Oriana Bermudez </remarks>
    /// <remarks> Date: Apr 25, 2023 </remarks>
    public partial class Course : BaseModel
    {
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

        public Course() { }
    }
}
