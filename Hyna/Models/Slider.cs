using System;
using System.ComponentModel.DataAnnotations;

namespace Hyna.Models
{
    public class Slider
    {
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Title { get; set; }

        [Required]
        [StringLength(150)]
        public string Slogan { get; set; }

        [StringLength(50)]
        public string MoreText { get; set; }

        [StringLength(50)]
        public string MoreUrl { get; set; }

    }
}
