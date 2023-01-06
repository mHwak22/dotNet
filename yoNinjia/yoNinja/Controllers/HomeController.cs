using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using yoNinja.Models;
using User;
using System;
using System.Text.Json;
using System.IO;
using System.Text;
namespace yoNinja.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Login()
    {
        return View();
    }

    public IActionResult Registraton()
    {
        return View();
    }
    public IActionResult Validate(string email, string password){
        if(email=="mohakyo123@gmail.com" && password=="12moh"){
            return Redirect("/home/Index");
        }
        else 
        return View();
    }
    List<Student> students=new List<Student>();
     public IActionResult InsertData(string firstName, string lastName, string motherName, string fatherName, string dob, 
    
    string gender, string address,string state, string pincode, string course, string email){
        students.Add(new Student(firstName, lastName, motherName, fatherName, dob, gender, address,state, pincode, course, email));
        
        // string? fileName=@"D:\cdac\dotNET\yoNinjia\yoNinja\yoNinj.json";
        // // var options=new JsonSerializerOptions {IncludeFields=true};
        // string? stdDetailsJson= JsonSerializer.Serialize<List<Student>>(students);
    
        // File.WriteAllText(fileName,stdDetailsJson);
        var options=new JsonSerializerOptions {IncludeFields=true};
            var produtsJson=JsonSerializer.Serialize<List<Student>>(students,options);
            string fileName=@"D:\mhwak\products.json";
            //Serialize all Flowers into json file

            File.WriteAllText(fileName,produtsJson);
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
