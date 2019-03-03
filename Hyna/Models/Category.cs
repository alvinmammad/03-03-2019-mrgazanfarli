using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Hyna.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public List<Blog> Blogs { get; set; }

        public List<ProjectCategory> Projects { get; set; }
    }
}
