using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using Infrustructor.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrustructor.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityDBContext _ctx;
        public CourseRepository(UniversityDBContext ctx)
        {
            _ctx = ctx;
        }

        public async Task AddCourse(Course course)
        {
            await _ctx.Courses.AddAsync(course);
        }

        public IEnumerable<Course> GetCourses()
        {
            return _ctx.Courses;
        }

        public Course GetCoursForShow(int id)
        {
            return _ctx.Courses.Find(id);
        }

    }
}
