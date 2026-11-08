using System.ComponentModel.DataAnnotations;


public class Person
{
    public int Id { get; set; }

    [Required(ErrorMessage = "We need first name")]
    [Display(Name = "First Name")] //As in form we are direcly using object Properties to display name we can modify or change from here on our own choice
    public string FirstName { get; set; }

    [Required(ErrorMessage = "We need last name")]
    [Display(Name = "Last Name")]
    public string SurName { get; set; }
    public string Address { get; set; }
    public char Gender { get; set; } = 'M';
    public double Salary { get; set; }

    public static List<Person> GetEmployees()
    {
        //This is object Initializer syntax
        Person emp1 = new Person() { Id = 1, FirstName = "sachin", SurName = "sapkota", Address = "kathmandu", Salary = 20000.0 };
        Person emp2 = new Person() { Id = 2, FirstName = "John", SurName = "Doe", Address = "pokhara", Salary = 10000.0 };
        Person emp3 = new Person() { Id = 3, FirstName = "Teena", SurName = "garg", Address = "lalitpur", Salary = 20000.0 };
        Person emp4 = new Person() { Id = 4, FirstName = "Mia", SurName = "Sharma", Address = "Florida", Salary = 20000.0 };
        Person emp5 = new Person() { Id = 5, FirstName = "Leah", SurName = "Halton", Address = "california", Salary = 20000.0 };
        Person emp6 = new Person() { Id = 6, FirstName = "Brook", SurName = "Monk", Address = "Las Vegas", Salary = 20000.0 };
        List<Person> employees = new List<Person> { emp1, emp2, emp3, emp4, emp5, emp6 };

        return employees;
    }

}
