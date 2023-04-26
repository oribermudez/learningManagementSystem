using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.ViewModels
{
    /// <summary>
    /// Manages Course List Page
    /// </summary>
    /// <remarks> Authors: Matthew Yackel, Ana Alarcon, Oriana Bermudez </remarks>
    /// <remarks> Date: Apr 25, 2023 </remarks>
    public partial class CourseListViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Course> courses = new();

        /// <summary>
        /// Retrieves the courses from the database.
        /// </summary>
        /// <exception cref="CannotPopulateListException"></exception>
        [RelayCommand]
        public void DisplayCourses()
        {
            Courses.Clear();
            DBConnect dBConnect = new();

            try
            {
                List<Course> list = dBConnect.GetCourses();
                foreach (var item in list) Courses.Add(item);
            }
            catch
            {
                throw new CannotPopulateListException();
            }

        }
    }
 }
