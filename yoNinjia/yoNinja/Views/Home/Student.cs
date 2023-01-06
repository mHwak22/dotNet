namespace User;

public class Student
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? MotherName { get; set; }
    public string? FatherName { get; set; }
    public string? DOB { get; set; }
    public string? Gender { get; set; }
    public string? Address { get; set; }
    public string? State { get; set; }
    public string? Pincode { get; set; }
    public string? Course { get; set; }
    public string? Email { get; set; }

    public Student(string firstName, string lastName, string motherName, string fatherName, string dob, 
    string gender, string address,string state, string pincode, string course, string email){
        this.FirstName=firstName;
        this.LastName=lastName;
        this.MotherName=motherName;
        this.FatherName=fatherName;
        this.DOB=dob;
        this.Gender=gender;
        this.Address=address;
        this.State=state;
        this.Pincode=pincode;
        this.Course=course;
        this.Email=email;
    }
}