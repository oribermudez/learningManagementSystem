using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using Security;

namespace LearningManagementSystem
{

    public class DBConnect
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

            OpenConnection();

            CloseConnection();
        }

        /// <summary>
        /// Initializes DB values
        /// </summary>
        private void Initialize()
        {
            server = "localhost";
            database = "studentmanagementsystem";
            uid = "root";
            password = "password";
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


        //Insert statement
        public List<Course> GetCourses()
        {
            List<Course> _courses = new List<Course>();

            // Open the connection to the database
            if (this.OpenConnection() == true)
            {
                // SELECT courses from DB
                string query = "SELECT * FROM courses";

                // Create a command object
                MySqlCommand cmd = new MySqlCommand(query, connection);

                // Execute the query and get a data reader
                MySqlDataReader dataReader = cmd.ExecuteReader();

                // Loop through records/rows returned by the query
                while (dataReader.Read())
                {
                    // Get the values of the columns for this row
                    int id = Convert.ToInt32(dataReader["id"]);
                    string name = Convert.ToString(dataReader["name"]);
                    string instructor = Convert.ToString(dataReader["instructor"]);
                    DateTime startDate = Convert.ToDateTime(dataReader["start_date"]);
                    DateTime endDate = Convert.ToDateTime(dataReader["end_date"]);

                    // Create a new Course object and add it to the list
                    Course course = new Course(id, name, instructor, startDate, endDate);
                    _courses.Add(course);

                }
                // Close the data reader and the database connection
                dataReader.Close();
                this.CloseConnection();
            }

            // Return the list of courses
            return _courses;
        }


        //    // Create new Course instance/object/model from column data
        //    Course objectOrientedProgramming = new Course(101, "OOP2", "Nick", new DateTime(2023, 01, 09), new DateTime(2023, 04, 25));

        //// Add new Course instance to List
        ///









        public void UpdateCourse(int id, string name, string instructor)
        {
            string query = "UPDATE courses SET name = @name, instructor = @instructor WHERE id = @id";

            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }


            //Open connection
            if (this.OpenConnection() == true)
            {

                // Create a command to update the course with the given ID
                MySqlCommand command = new MySqlCommand();

                //Assign the query using CommandText
                command.CommandText = query;

                //Assign the connection using Connection
                command.Connection = connection;


                //Execute query
                command.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }


        public Course ViewCourse(string name)
        {
            string query = "SELECT * FROM courses WHERE name = @name";

            // Open connection
            if (this.OpenConnection() == true)
            {
                // Create a command to retrieve the course with the given name
                MySqlCommand command = new MySqlCommand(query, connection);

                // Add parameters to the command
                command.Parameters.AddWithValue("@name", name);

                // Execute the query and get a data reader
                MySqlDataReader reader = command.ExecuteReader();

                // Check if there is a row to read
                if (reader.Read())
                {
                    // Create a new Course object with data from the reader
                    Course course = new Course(
                        Convert.ToInt32(reader["id"]),
                        reader["name"].ToString(),
                        reader["instructor"].ToString(),
                        Convert.ToDateTime(reader["startDate"]),
                        Convert.ToDateTime(reader["endDate"])
                    );

                    // Close the reader and connection
                    reader.Close();
                    this.CloseConnection();

                    // Return the course object
                    return course;
                }
                else
                {
                    // No rows were returned, so close the reader and connection and return null
                    reader.Close();
                    this.CloseConnection();
                    return null;
                }
            }
            else
            {
                // Connection could not be opened, so return null
                return null;
            }
        }


    }


}
