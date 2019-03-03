using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Hyna.Models
{
    public class Author
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Fullname { get; set; }

        [Required]
        [StringLength(50)]
        public string Position { get; set; }

        [Required]
        [StringLength(250)]
        public string Photo { get; set; }

        public string Desc { get; set; }

        public List<Blog> Blogs { get; set; }
    }
}
