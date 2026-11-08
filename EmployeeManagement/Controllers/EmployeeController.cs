

using EmployeeManagement.Data;
using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller
{

    // public ActionResult<string> Index()
    public IActionResult Index() //you can use IActionResult  and not need to provide return type. Actually ActionResult inherit class IActionResult you can see implementation
    {

        //Action Result is build iclass that helps to define action and the name we provice to ActionResult is used in url .so for our case : /employee/index -->index is action
        //ActoinResult is generic class and we have to mention the return type too
        // return "I am from employee index"; -->This will normally return this string

        // var employees = Person.GetEmployees();
        var db = new EmsContext();
        var employees = db.Employees.ToList();
        return View(employees); // --> View is also a built in class. Now this controller starts looking same name ie:Employee folder,inside that index file  inside Views folder
    }

    // public IActionResult Detail(string firstName) -->firstName is query passed from url .
    public IActionResult Detail([FromQuery] int id)
    {
        var employees = Person.GetEmployees();
        // var employee = employees.Where(x => x.FirstName == firstName).First();
        var employee = employees.FirstOrDefault(x => x.Id == id);//this is more efficient


        return View(employee);
    }

    public IActionResult Add() //This is for handling get request ie.form element
    {
        return View();//employee/add will search for Add.cshtml as we dont pass any name in View();
    }

    // [HttpPost] //--> now this below Add controller handles post method. [HttpGet] is default so we don't mention it above 
    // public ActionResult<string> Add([FromForm] Person person) //you can give other name instead of Add and then use same name in form but for better consistency we are using method overload . Now ,insdie Add we write Person person .as we are dyanmically using the same object properties inside form elements so it will automically bind to this object person.This is also called model binding.[FromForm] is hint similar as we did in with id ie:[FromQuery]
    // {



    //     // Save employee record here

    //     return "Record Saved Successfully!";




    // }


    [HttpPost]
    public IActionResult Add([FromForm] Person person)
    {
        if (!ModelState.IsValid)
        {
            // Return the same view with the posted model so the
            // validation messages appear next to the fields
            return View(person);
        }

        // Save employee record here

        return Content("Record Saved Successfully!");
    }
}

