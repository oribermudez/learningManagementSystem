using MySqlConnector;

namespace LearningManagementSystem
{


    public class Course
    {

        //fields
        public int Id { get; set; }
        public string Name { get; set; }
        public string Instructor { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }



        //constructor
        public Course(int id, string name, string instructor, DateTime startDate, DateTime endDate)
        {
            Id = id;
            Name = name;
            Instructor = instructor;
            StartDate = startDate;
            EndDate = endDate;
        }

        //create a list of courses
        private static List<Course> _courses;



        static Course()
        {
            //initialize the list with some sample data
            _courses = new List<Course>
            {
                new Course(1, "Mathematics", "John Doe", new DateTime(2022, 9, 1), new DateTime(2022, 12, 15)),
                new Course(2, "Physics", "Jane Smith", new DateTime(2022, 9, 1), new DateTime(2022, 12, 15)),
                new Course(3, "Chemistry", "Bob Johnson", new DateTime(2022, 9, 1), new DateTime(2022, 12, 15)),
                new Course(4, "Biology", "Alice Brown", new DateTime(2022, 9, 1), new DateTime(2022, 12, 15)),
            };
        }

        //i wanted to try get the list of courses
        public static List<Course> GetCourses()
        {
            return _courses;
        }



        //public void UpdateCourse(int id, string name, string instructor)
        //{
        //    if (string.IsNullOrEmpty(name))
        //    {
        //        throw new ArgumentNullException(nameof(name));
        //    }

        //    //define found boolean to false 
        //    bool found = false;

        //    //loop through list
        //    for (int i = 0; i < _courses.Count - 1; i++)
        //    {
        //        //check if current course Id matches id argument
        //        if (_courses[i].Id == id)
        //        {
        //            //assign name argument to NAME PROPERTY for course
        //            _courses[i].Name = name;

        //            //assign name instructor to Instructor PROPERTY for course
        //            _courses[i].Instructor = instructor;

        //            //assigned found to true
        //            found = true; break;
        //        }

        //        if (found == false)
        //        {
        //            //need to implement an exception
        //            throw new NotImplementedException();
        //        }
        //    }
        //}


        public void ExampleMethodToViewCourse()
        {
            DBConnect db = new DBConnect();
            Course mathCourse = db.ViewCourse("Mathematics");
        }






    }
}
