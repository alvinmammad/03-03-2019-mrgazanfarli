using System;
using System.ComponentModel.DataAnnotations;

namespace Hyna.Models
{
    public class ProjectCategory
    {
        public int Id { get; set; }

        [Required]
        public int ProjectId { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public Category Category { get; set; }
        public Project Project { get; set; }
    }
}
