using HW5_PRO.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HW5_PRO.Controllers
{
    public class StudentController : Controller
    {
        private readonly ILogger<StudentController> _logger;

        public StudentController(ILogger<StudentController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Submit(string firstName, string lastName, string group, int grade1, int grade2, int grade3, string[] programmingLanguages)
        {
            var student = new StudentViewModel()
            {
                FirstName = firstName,
                LastName = lastName,
                Group = group,
                Grades = new[] { grade1, grade2, grade3 },
                LanguagesOfProgramming = programmingLanguages?.ToList() ?? new List<string>()
            };
            return View(student);
        }
    }
}