using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hyna.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hyna.Controllers
{
    [Route("api/[controller]")]
    public class AboutController : Controller
    {
        private readonly HynaContext _context;

        public AboutController(HynaContext context)
        {
            _context = context;
        }

        // GET: api/values
        [HttpGet]
        public object Get()
        {
            var about = _context.Abouts.FirstOrDefault();

            return new
            {
                about.Title,
                about.Text,
                Photo = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}/images/{about.Photo}"
            };
        }
    }
}
