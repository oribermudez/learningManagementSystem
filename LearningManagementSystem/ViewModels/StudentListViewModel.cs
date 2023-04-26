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
    /// <summary>
    /// Manages Student List Page
    /// </summary>
    /// <remarks> Authors: Matthew Yackel, Ana Alarcon, Oriana Bermudez </remarks>
    /// <remarks> Date: Apr 25, 2023 </remarks>
    public partial class StudentListViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Student> students = new();

        /// <summary>
        /// Retrieves the students from the database 
        /// </summary>
        /// <exception cref="CannotPopulateListException"></exception>
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

        /// <summary>
        /// Deletes a student from the database
        /// </summary>
        /// <param name="student"></param>
        /// <exception cref="CannotDeleteStudentException"></exception>
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

        /// <summary>
        /// Navigates to EditStudentPage
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        [RelayCommand]
        async Task GoToEditStudent(Student student)
        {

            await Shell.Current.Navigation.PushAsync(new EditStudentPage(student));
        }
    }
}
