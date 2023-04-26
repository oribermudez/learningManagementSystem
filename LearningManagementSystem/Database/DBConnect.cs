

namespace LearningManagementSystem.Database
{
    /// <summary>
    /// Manages the DB
    /// </summary>
    /// <remarks> Authors: Matthew Yackel, Ana Alarcon, Oriana Bermudez </remarks>
    /// <remarks> Date: Apr 25, 2023 </remarks>
    public partial class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        /// <summary>
        /// Initializes DB values
        /// </summary>
        private void Initialize()
        {
            server = "localhost";
            database = "studentmanagementsystem";
            uid = "root";
            password = "1234";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        /// <summary>
        /// Open the connection to the database
        /// </summary>
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server.");
                        break;

                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        /// <summary>
        /// Closes the connection to the database
        /// </summary>
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Insert new student object into the students table in the database
        /// </summary>
        /// <param name="newStudent">Student object</param>
        public void InsertNewStudent(Student newStudent)
        {
            string query = $"INSERT INTO students (firstName, lastName, program, phone, email) VALUES ('{newStudent.FirstName}', '{newStudent.LastName}', '{newStudent.Program}', '{newStudent.Phone}', '{newStudent.Email}')";

            //open connection
            if (OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                CloseConnection();
            }
        }

        /// <summary>
        /// Update student record
        /// </summary>
        /// <param name="studentId"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="program"></param>
        /// <param name="phone"></param>
        /// <param name="email"></param>
        public void UpdateStudent(int studentId, string firstName, string lastName, string program, string phone, string email)
        {
            string query = $"UPDATE students SET firstName='{firstName}', lastName='{lastName}', program='{program}', phone='{phone}', email='{email}' WHERE studentId='{studentId}'";

            //Open connection
            if (OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                CloseConnection();
            }
        }

        /// <summary>
        /// Deletes a student record
        /// </summary>
        /// <param name="id"></param>
        public void DeleteStudent(int id)
        {
            string query = $"DELETE FROM students WHERE studentId='{id}'";

            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }

        /// <summary>
        /// Gets all the students of the database
        /// </summary>
        /// <returns></returns>
        public List<Student> GetStudents()
        {
            string query = "SELECT * FROM students";

            //Create a list to store the result
            List<Student> list = new List<Student>();

            //Open connection
            if (OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    Student student = new Student();
                    student.Id = (int)dataReader["studentId"];
                    student.FirstName = (string)dataReader["firstName"];
                    student.LastName = (string)dataReader["lastName"];
                    student.Program = (string)dataReader["program"];
                    student.Phone = (string)dataReader["phone"];
                    student.Email = (string)dataReader["email"];

                    list.Add(student);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        /// <summary>
        /// Gets all the courses of the database
        /// </summary>
        /// <returns></returns>
        public List<Course> GetCourses()
        {
            string query = "SELECT * FROM courses";

            //Create a list to store the result
            List<Course> list = new List<Course>();

            //Open connection
            if (OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    Course course = new Course();
                    course.Id = (int)dataReader["courseId"];
                    course.Name = (string)dataReader["courseName"];
                    course.Instructor = (string)dataReader["instructor"];
                    course.StartDate = (DateTime)dataReader["startDate"];
                    course.EndDate = (DateTime)dataReader["endDate"];

                    list.Add(course);
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }
    }
}
