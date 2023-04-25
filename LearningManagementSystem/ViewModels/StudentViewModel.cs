using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LearningManagementSystem.Database;
using LearningManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningManagementSystem.Exceptions;

namespace LearningManagementSystem.ViewModels
{
    public partial class StudentViewModel : ObservableValidator
    {
        [ObservableProperty]
        private string result;

        private int id;

        [Required(ErrorMessage = "The id is required.")]
        public int Id
        {
            get => id;

            set => SetProperty(ref id, value, true);
        }

        private string firstName;

        [Required(ErrorMessage = "The first name is required.")]
        public string FirstName
        {
            get => firstName;

            set => SetProperty(ref firstName, value, true);
        }

        private string lastName;

        [Required(ErrorMessage = "The last name is required.")]
        public string LastName
        {
            get => lastName;

            set => SetProperty(ref lastName, value, true);
        }

        private string program;

        [Required(ErrorMessage = "The program is required.")]
        public string Program
        {
            get => program;

            set => SetProperty(ref program, value, true);
        }

        private double phone;

        [Required(ErrorMessage = "The phone is required.")]
        public double Phone
        {
            get => phone;

            set => SetProperty(ref phone, value, true);
        }

        private string email;

        [Required(ErrorMessage = "The email is required.")]
        public string Email
        {
            get => email;

            set => SetProperty(ref email, value, true);
        }

        public ObservableCollection<string> Errors { get; set; } = new();

        [RelayCommand]
        async Task GoToList()
        {
            await Shell.Current.GoToAsync("StudentListPage");
        }

        [RelayCommand]
        public void AddStudent()
        {
            ValidateAllProperties();

            Errors.Clear();
            GetErrors(nameof(Id)).ToList().ForEach(f => Errors.Add(f.ErrorMessage));
            GetErrors(nameof(FirstName)).ToList().ForEach(f => Errors.Add(f.ErrorMessage));
            GetErrors(nameof(LastName)).ToList().ForEach(f => Errors.Add(f.ErrorMessage));
            GetErrors(nameof(Program)).ToList().ForEach(f => Errors.Add(f.ErrorMessage));
            GetErrors(nameof(Phone)).ToList().ForEach(f => Errors.Add(f.ErrorMessage));
            GetErrors(nameof(Email)).ToList().ForEach(f => Errors.Add(f.ErrorMessage));
            if (Errors.Count > 0) return;


            Student newStudent = new Student(Id, FirstName, LastName, Program, Phone, Email);

            DBConnect dBConnect = new();

            try
            {
                dBConnect.InsertNewStudent(newStudent);
            }
            catch
            {
                throw new CannotAddStudentException();
            }
            finally
            {
                Result = $" The student {Id} was successfully added.";
                Id= 0 ;
                FirstName = string.Empty ;
                LastName = string.Empty ;
                Program = string.Empty ;
                Phone = 0;
                Email = string.Empty;
            }
        }
    }
}
