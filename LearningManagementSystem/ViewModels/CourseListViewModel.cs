using LearningManagementSystem.Models;
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
        public async Task DisplayCourses()
        {
            Courses.Clear();
            DBConnect dBConnect = new();
            List<Course> list = dBConnect.getCourses();
            foreach (var item in list) Courses.Add(item);

        }

        [RelayCommand]
        async Task GoTo()
        {
            await Shell.Current.GoToAsync("AddCoursesPage");
        }

        [RelayCommand]
        public async Task DeleteCourse(Course course)
        {
            DBConnect dBConnect = new();
            dBConnect.DeleteCourse(course.Id);
            await DisplayCourses();
        }
    }
}
