using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.Web.Controllers
{
    public class CourseController : Controller
    {
        private ICourseService _courseService;
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        public IActionResult Index()
        {
            CourseViewModel course = _courseService.GetCourses();
            return View(course);
        }
        public IActionResult ShowCourse(int id)
        {
            ShowCourseViewModel course = _courseService.GetCourseForShow(id);
            if (course==null)
            {
                return NotFound();
            }
            return View(course);
        }
        [BindProperty]
        public AddCourseViewModel Course { get; set; }
        //public async Task<IActionResult> CreateCourse()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public async Task<IActionResult> CreateCourse()
        //{
        //    return View();
        //}

    }
}