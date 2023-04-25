using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LearningManagementSystem.Database;
using LearningManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.ViewModels
{
    public partial class CourseViewModel : ObservableValidator
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

        private string name;

        [Required(ErrorMessage = "The name is required.")]
        public string Name
        {
            get => name;

            set => SetProperty(ref name, value, true);
        }

        private string instructor;

        [Required(ErrorMessage = "The instructor is required.")]
        public string Instructor
        {
            get => instructor;

            set => SetProperty(ref instructor, value, true);
        }

        private DateTime startDate;

        [Required(ErrorMessage = "The start date is required.")]
        public DateTime StartDate
        {
            get => startDate;

            set => SetProperty(ref startDate, value, true);
        }

        private DateTime endDate;

        [Required(ErrorMessage = "The end date is required.")]
        public DateTime EndDate
        {
            get => endDate;

            set => SetProperty(ref endDate, value, true);
        }



        public ObservableCollection<string> Errors { get; set; } = new();

        [RelayCommand]
        public async Task UpdateCourse(Course course)
        {
            ValidateAllProperties();

            Errors.Clear();
            GetErrors(nameof(Id)).ToList().ForEach(f => Errors.Add("Id:" + f.ErrorMessage));
            GetErrors(nameof(Name)).ToList().ForEach(f => Errors.Add("Course Name:" + f.ErrorMessage));
            GetErrors(nameof(Instructor)).ToList().ForEach(f => Errors.Add("Instructor:" + f.ErrorMessage));
            GetErrors(nameof(StartDate)).ToList().ForEach(f => Errors.Add("Start Date:" + f.ErrorMessage));
            GetErrors(nameof(EndDate)).ToList().ForEach(f => Errors.Add("End Date:" + f.ErrorMessage));
            if (Errors.Count > 0) return;

            Course updatedCourse = new Course(id, name, instructor, startDate, endDate);

            DBConnect dBConnect = new();
            dBConnect.UpdateCourse(updatedCourse);

            Result = $" The course {id} was successfully updated.";
        }

    }
}
