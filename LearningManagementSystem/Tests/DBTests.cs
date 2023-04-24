using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LearningManagementSystem.DBConnect;

namespace LearningManagementSystem.Tests
{
    public class CourseTests
    {
        private List<Course> _courses;

        [SetUp]
        public void Setup()
        {
            // Initialize the list with some sample data
            _courses = new List<Course>
            {
                new Course(1, "Mathematics", "John Doe", new DateTime(2022, 9, 1), new DateTime(2022, 12, 15)),
                new Course(2, "Physics", "Jane Smith", new DateTime(2022, 9, 1), new DateTime(2022, 12, 15)),
                new Course(3, "Chemistry", "Bob Johnson", new DateTime(2022, 9, 1), new DateTime(2022, 12, 15)),
                new Course(4, "Biology", "Alice Brown", new DateTime(2022, 9, 1), new DateTime(2022, 12, 15)),
            };
        }

        [TearDown]
        public void TearDown()
        {
            // Reset the list to null after each test
            _courses = null;
        }

        [Test]
        public void TestGetCourses()
        {
            // Arrange
            var expectedCourses = _courses;

            // Act
            var db = new DBConnect();
            var actualCourses = db.GetCourses();

            // Assert
            Assert.AreEqual(expectedCourses, actualCourses);
        }
    }
}
