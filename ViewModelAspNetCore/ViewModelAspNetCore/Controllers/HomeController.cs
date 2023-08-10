using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ViewModelAspNetCore.Models;

namespace ViewModelAspNetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Student> Student = new List<Student>
            {
                new Student{ID=101,Name="Shyam",Gender="Male",Standard=11},
                new Student{ID=102,Name="Amol",Gender="Male",Standard=12},
                new Student{ID=103,Name="Ajay",Gender="Male",Standard=10},
            };
            //Teacher list

            List<Teacher> Teacher = new List<Teacher>
            {
                new Teacher{ID=101,Name="Shyam",Qualification="Bsc cs",salary=11000},
                new Teacher{ID=102,Name="Amol",Qualification="Phd",salary=12000},
                new Teacher{ID=103,Name="Ajay",Qualification="B come",salary=2900},
            };
            //
            SchoolViewModel svm = new SchoolViewModel()
            {
                MyStudents = Student,
                MyTeachers = Teacher,

            };
            return View(svm);
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
}