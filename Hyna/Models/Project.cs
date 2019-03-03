using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hyna.Models
{
    public class Project
    {
        public int Id { get; set; }

        [StringLength(250)]
        public string Slug { get; set; }

        [Required]
        [StringLength(250)]
        public string Name { get; set; }

        [Required]
        [StringLength(250)]
        public string Photo { get; set; }

        [Required, MinLength(250)]
        [Column(TypeName = "text")]
        public string Text { get; set; }

        public List<ProjectCategory> Categories { get; set; }
    }
}
