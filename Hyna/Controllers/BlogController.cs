using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hyna.Data;
using Microsoft.AspNetCore.Mvc;
using Hyna.Models;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Hyna.Controllers
{
    [Route("api/[controller]")]
    public class BlogController : Controller
    {
        private readonly HynaContext _context;

        public BlogController(HynaContext context)
        {
            _context = context;
        }

        // GET: api/values
        [HttpGet]
        public object Get()
        {
            var data = _context.Blogs.Include("Author").OrderByDescending(b => b.Date).ToList();

            return data.Select(d => new
            {
                d.Id,
                d.Slug,
                d.Title,
                Photo = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}/images/{d.Photo}",
                Date = d.Date.ToString("dd MMMM yyyy"),
                d.Desc,
                Author = new
                {
                    d.Author.Fullname,
                    Photo = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}/images/{d.Author.Photo}"
                }
            });
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public object Get(int id)
        {
            var d = _context.Blogs.Include("Author").FirstOrDefault(b => b.Id == id);
            if (d == null)
            {
                return NotFound();
            }

            return  new
            {
                d.Id,
                d.Slug,
                d.Title,
                Photo = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}/images/{d.Photo}",
                Date = d.Date.ToString("dd MMMM yyyy"),
                d.Desc,
                d.Text,
                Author = new
                {
                    d.Author.Fullname,
                    Photo = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}/images/{d.Author.Photo}"
                }
            };
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
