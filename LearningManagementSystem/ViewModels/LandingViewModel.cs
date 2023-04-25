using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.ViewModels
{
    public partial class LandingViewModel : ObservableObject
    {
        [RelayCommand]
        static async Task GoToStudentList()
        {
            await Shell.Current.GoToAsync("StudentListPage");
        }

        [RelayCommand]
        static async Task GoToAddStudent()
        {
            await Shell.Current.GoToAsync("AddStudentPage");
        }
    }
}
