using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.ViewModels
{
    public partial class CourseListViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Course> courses = new();

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
