

using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller
{

    // public ActionResult<string> Index()
    public IActionResult Index() //you can use IActionResult  and not need to provide return type. Actually ActionResult inherit class IActionResult you can see implementation

    {
        //This is object Initializer syntax
        Person emp1 = new Person() { FirstName = "sachin", SurName = "sapkota", Address = "kathmandu", Salary = 20000.0 };
        Person emp2 = new Person() { FirstName = "John", SurName = "Doe", Address = "pokhara", Salary = 10000.0 };
        Person emp3 = new Person() { FirstName = "Teena", SurName = "garg", Address = "lalitpur", Salary = 20000.0 };
        Person emp4 = new Person() { FirstName = "Mia", SurName = "Sharma", Address = "Florida", Salary = 20000.0 };
        Person emp5 = new Person() { FirstName = "Leah", SurName = "Halton", Address = "california", Salary = 20000.0 };
        Person emp6 = new Person() { FirstName = "Brook", SurName = "Monk", Address = "Las Vegas", Salary = 20000.0 };

        List<Person> employees = new List<Person> { emp1, emp2, emp3, emp4, emp5, emp6 };


        //Action Result is build in class that helps to define action and the name we provice to ActionResult is used in url .so for our case : /employee/index -->index is action
        //ActoinResult is generic class and we have to mention the return type too
        // return "I am from employee index"; -->This will normally return this string
        return View(employees); // --> View is also a built in class. Now this controller starts looking same name ie:Employee folder,inside that index file  inside Views folder
    }

}

public class Person
{
    public string FirstName { get; set; }
    public string SurName { get; set; }
    public string Address { get; set; }
    public char Gender { get; set; } = 'M';
    public double Salary { get; set; }

}