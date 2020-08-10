using CleanArch.Application.ViewModel;
using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Interfaces
{
    public interface ICourseService
    {
        CourseViewModel GetCourses();
        ShowCourseViewModel GetCourseForShow(int id);
        Course AddCourse(AddCourseViewModel model);
    }
}
