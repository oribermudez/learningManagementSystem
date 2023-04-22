namespace LearningManagementSystem;

public partial class AddUserPage : ContentPage
{
    public AddUserPage()
    {
        InitializeComponent();
    }
    private void SubmitButton_Clicked(object sender, EventArgs e)
    {
        //string search = this.SearchEntry.Text;
        int id = int.Parse(this.IdEntry.Text);
        string firstName = this.FirstNameEntry.Text;
        string lastName = this.LastNameEntry.Text;
        string program = this.ProgramEntry.Text;
        double phone = double.Parse(this.PhoneEntry.Text);
        string email = this.EmailEntry.Text;

        DBConnect dBConnect = new DBConnect();
        Student newStudent = new Student(id, firstName, lastName, program, phone, email);

        dBConnect.InsertNewStudent(newStudent);

        DisplayAlert("Success!", "New student added to the database successfully.", "OK");

        this.IdEntry.Text = "";
        this.FirstNameEntry.Text = "";
        this.LastNameEntry.Text = "";
        this.ProgramEntry.Text = "";
        this.PhoneEntry.Text = "";
        this.EmailEntry.Text = "";
    }
}