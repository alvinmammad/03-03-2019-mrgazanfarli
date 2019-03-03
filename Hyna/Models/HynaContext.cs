using System;
using Microsoft.EntityFrameworkCore;

namespace Hyna.Data
{
    public class HynaContext:DbContext
    {
        public HynaContext(DbContextOptions options):base(options)
        {
        }
    }
}
