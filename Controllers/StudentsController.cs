using Microsoft.AspNetCore.Mvc;
using Zadanie_16.Models;

namespace Zadanie_16.Controllers;

public class StudentsController : Controller
{
    public ViewResult Index()
    {
        var list = new List<Student>();
        var s1 = new Student()
        {
            StudentId = 1,
            LName = "Kowalski",
            Email = "Kowalski@gmail.com"
        };
        var s2 = new Student()
        {
            StudentId = 2,
            LName = "Nowak",
            Email = "Nowak@gmail.com"
        };
        list.Add(s1);
        list.Add(s2);
        return View(list);
    }

    public ViewResult Create()
    {
        
    }
}