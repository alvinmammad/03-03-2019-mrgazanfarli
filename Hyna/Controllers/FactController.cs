using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hyna.Data;
using Microsoft.AspNetCore.Mvc;
using Hyna.Models;


namespace Hyna.Controllers
{
    [Route("api/[controller]")]
    public class FactController : Controller
    {
        private readonly HynaContext _context;

        public FactController(HynaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Fact> Get()
        {
            return _context.Facts.OrderBy(f=>f.OrderBy);
        }
    }
}
