using System;
using System.ComponentModel.DataAnnotations;

namespace Hyna.Models
{
    public class Partner
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Url { get; set; }

        [Required]
        [StringLength(250)]
        public string Logo { get; set; }
    }
}
