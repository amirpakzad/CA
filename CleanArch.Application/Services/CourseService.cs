using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModel;
using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {
        private ICourseRepository _courseRepository;
        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public Course AddCourse(AddCourseViewModel model)
        {
            return new Course
            {
                Description = model.Description,
                ImageUrl = model.ImageUrl,
                Name = model.Name
            };
        }

        public ShowCourseViewModel GetCourseForShow(int id)
        {
            var course = _courseRepository.GetCoursForShow(id);
            return new ShowCourseViewModel
            {
                ID=course.ID,
                Description=course.Description,
                ImageUrl=course.ImageUrl,
                Name=course.Name
            };
        }

        public CourseViewModel GetCourses()
        {
            return new CourseViewModel()
            {
                Courses = _courseRepository.GetCourses()
            };
        }
    }
}
