using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tester.Models;

namespace Tester.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly StudentContext _context;



        public StudentsController(StudentContext context)

        {
            _context = context;
        }
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Student>>> GetStudents()
        //{
        //    return await _context.Students/*.Include(s => s.Course)*/.ToListAsync();

        //}
        //    [HttpGet("{id}")]
        //    public async Task<ActionResult<IEnumerable<Course>>> GetCourses()
        //    { 

        //        return await _context.Courses./*Include(s => s.Courses).*/ToListAsync();
        //}
        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetStudent(int id)
        {
            var course = await _context.Students.FindAsync(id);

            if (course == null)
            {
                return NotFound();
            }

            return course;
        }
    }

}



