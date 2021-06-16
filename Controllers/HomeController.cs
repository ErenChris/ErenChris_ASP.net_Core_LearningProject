using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentManagment.Models;

namespace StudentManagment.Controllers
{
    public class HomeController : Controller
    {
        public readonly IStudentRepository _studentRepository;

        public HomeController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public string Index()
        {
            return _studentRepository.GetStudent(1).EmailAddress;
        }

        public ActionResult Details()
        {
            Student model = _studentRepository.GetStudent(1);

            return View(model);
        }
    }
}
