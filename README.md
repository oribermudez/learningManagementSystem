<!-- PROJECT LOGO -->
<br />
<div align="center">
  <h1 align="center">Learning 360</h1>
  <p align="center">
    A learning management system to review and update student information. 
  </p>
</div>



<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project

This project represents the culmination of our learning journey in C# object-oriented programming. We had the opportunity to design and build it from the ground up, leveraging the power and flexibility of the MAUI framework and the elegant MVVM pattern. By seamlessly integrating with a MariaDB database, our project achieves a robust and scalable architecture, capable of handling complex data operations with ease.

Our project features a comprehensive CRUD (Create, Read, Update, Delete) implementation for the student model, empowering us to manage and maintain data with confidence and efficiency. Additionally, we have incorporated a streamlined "read-only" approach for the courses model, providing a simple and intuitive interface for users to access important information without the risk of accidental modification.

Overall, this project represents a significant milestone in our journey as developers, demonstrating our mastery of essential programming concepts and providing us with a solid foundation for future development endeavors.

<p align="right">(<a href="#readme-top">back to top</a>)</p>



### Built With

We used the following technologies:

* [.NET MAUI][Maui-url]
* [MariaDB][Maria-url]

<p align="right">(<a href="#readme-top">back to top</a>)</p>


<!-- GETTING STARTED -->
## Getting Started

To get a local copy up and running follow these simple example steps.

### Prerequisites

* Maria DB installed and running.
* Write down the password for your DB, we will need it later.
* Microsoft Visual Studio installed.
* Open Heidi SQL which is an open-source administration tool for MariaDB.

### Installation

1. Clone the repo via Github Desktop or directly on your terminal using:
   ```sh
   git clone https://github.com/oribermudez/learningManagementSystem
   ```
2. Navigate to the cloned folder on your local computer.
3. Find the file called:
   ```sh
    create_populate
   ```
4. Run the create_populate query on Heidi SQL and run it to create the database.
5. Open the project on Visual Studio by clicking on:
   ```sh
   LearningManagementSystem.sln
   ```
6. Navigate to the Database folder. 
7. Open the DBConnect class.
8. Go to the Initialize method and find the word "password".
9. Write your MariaDB password inside the quotes.
10. Now we are ready to start the application. Go to the Debug menu and click:
  ```sh
   Start Debugging
   ```
## Using the Program
For more information about how to use the program and an overview of what it can do, check out our <td><a href="https://www.youtube.com/watch?v=EdXDDsjNLxY" target="_blank">short video demo.</a></td>

<p align="right">(<a href="#readme-top">back to top</a>)</p>

<!-- MARKDOWN LINKS & IMAGES -->
[product-screenshot]: images/screenshot.png
[Maui-url]: https://learn.microsoft.com/en-us/dotnet/maui/?view=net-maui-7.0
[Maria-url]: https://mariadb.org/
