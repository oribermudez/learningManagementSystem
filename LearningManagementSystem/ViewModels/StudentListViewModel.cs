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
        public void UpdateStudent(Student student)
        {
            DBConnect dBConnect = new();

            try
            {
                dBConnect.UpdateStudent(student.Id, student.FirstName, student.LastName, student.Program, student.Phone, student.Email);
                DisplayStudents();
            }
            catch
            {
                throw new CannotDeleteStudentException();
            }
            finally
            {
                Updated = $"The student {student.Id} was successfully updated.";
            }
        }

        [RelayCommand]
        async Task GoToEditStudent(Student student)
        {
            SelectedStudent = student;

            await Shell.Current.GoToAsync("EditStudentPage");
        }
    }
}
