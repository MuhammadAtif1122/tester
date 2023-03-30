using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tester.Models;

namespace Tester.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {


        private readonly StudentContext _context;

        public HomeController(StudentContext context)
        {
            _context = context;
        }
        public string Get()
        {
            return "helow world";
        }
    }



   
}

   

