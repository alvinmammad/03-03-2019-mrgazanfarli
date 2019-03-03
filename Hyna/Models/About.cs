using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hyna.Models
{
    public class About
    {
        public int Id { get; set; }

        [Required]
        [StringLength(1000)]
        public string Title { get; set; }

        [Required]
        [StringLength(250)]
        public string Photo { get; set; }

        [Required, MinLength(250)]
        [Column(TypeName = "text")]
        public string Text { get; set; }
    }
}
