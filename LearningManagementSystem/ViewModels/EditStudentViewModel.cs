using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.ViewModels
{
    public partial class EditStudentViewModel: ObservableObject
    {
        [ObservableProperty]
        private Student selectedStudent;

        [ObservableProperty]
        private string updated;

        /// <summary>
        /// Updates a student's data 
        /// </summary>
        /// <exception cref="CannotDeleteStudentException"></exception>
        [RelayCommand]
        public void UpdateStudent()
        {
            DBConnect dBConnect = new();

            try
            {
                dBConnect.UpdateStudent(SelectedStudent.Id, SelectedStudent.FirstName, SelectedStudent.LastName, SelectedStudent.Program, SelectedStudent.Phone, SelectedStudent.Email);
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
    }
}
