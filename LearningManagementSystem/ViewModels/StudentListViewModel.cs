using LearningManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.ViewModels
{
    public partial class StudentListViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Student> students = new();

        [RelayCommand]
        public async Task DisplayStudents()
        {
            Students.Clear();
            DBConnect dBConnect = new();
            List<Student> list = dBConnect.getStudents();
            foreach (var item in list) Students.Add(item);

        }

        [RelayCommand]
        async Task GoTo()
        {
            await Shell.Current.GoToAsync("AddStudentPage");
        }

        [RelayCommand]
        public async Task DeleteStudent(Student student)
        {
            DBConnect dBConnect = new();
            dBConnect.Delete(student.Id);
            await DisplayStudents();
        }
    }
}
