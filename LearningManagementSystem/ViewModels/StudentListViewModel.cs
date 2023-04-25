using LearningManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LearningManagementSystem.ViewModels
{
    public partial class StudentListViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Student> students = new();

        [ObservableProperty]
        private Student selectedStudent;

        [ObservableProperty]
        private string updated;

        [RelayCommand]
        public void DisplayStudents()
        {
            Students.Clear();
            DBConnect dBConnect = new();

            try
            {
                List<Student> list = dBConnect.GetStudents();
                foreach (var item in list) Students.Add(item);
            }
            catch
            {
                throw new CannotPopulateListException();
            }

        }

        [RelayCommand]
        public void DeleteStudent(Student student)
        {
            DBConnect dBConnect = new();

            try
            {
                dBConnect.DeleteStudent(student.Id);
                DisplayStudents();
            }
            catch
            {
                throw new CannotDeleteStudentException();
            }
        }

        [RelayCommand]
        public void UpdateStudent()
        {
            DBConnect dBConnect = new();

            try
            {
                dBConnect.UpdateStudent(SelectedStudent.Id, SelectedStudent.FirstName, SelectedStudent.LastName, SelectedStudent.Program, SelectedStudent.Phone, SelectedStudent.Email);
                DisplayStudents();
            }
            catch
            {
                throw new CannotDeleteStudentException();
            }
            finally
            {
                Updated = $"The student was successfully updated.";
            }
        }

        [RelayCommand]
        async Task GoToEditStudent(Student student)
        {

            await Shell.Current.Navigation.PushAsync(new EditStudentPage(student));
        }
    }
}
