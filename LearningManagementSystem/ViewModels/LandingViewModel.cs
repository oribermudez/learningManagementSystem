using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.ViewModels
{
    /// <summary>
    /// Manages Landing Page
    /// </summary>
    /// <remarks> Authors: Matthew Yackel, Ana Alarcon, Oriana Bermudez </remarks>
    /// <remarks> Date: Apr 25, 2023 </remarks>
    public partial class LandingViewModel : ObservableObject
    {
        /// <summary>
        /// Navigates to StudentListPage within the application
        /// </summary>
        /// <returns></returns>
        [RelayCommand]
        static async Task GoToStudentList()
        {
            await Shell.Current.GoToAsync("StudentListPage");
        }

        /// <summary>
        /// Navigates to AddStudentPage within the application
        /// </summary>
        /// <returns></returns>
        [RelayCommand]
        static async Task GoToAddStudent()
        {
            await Shell.Current.GoToAsync("AddStudentPage");
        }


        /// <summary>
        /// Navigates to CourseListPage within the application
        /// </summary>
        /// <returns></returns>
        [RelayCommand]
        static async Task GoToCourseList()
        {
            await Shell.Current.GoToAsync("CourseListPage");
        }
    }
}
