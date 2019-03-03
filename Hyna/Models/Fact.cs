using System;
using System.ComponentModel.DataAnnotations;

namespace Hyna.Models
{
    public class Fact
    {
        public int Id { get; set; }

        [Required]
        public int OrderBy { get; set; }

        [Required]
        [StringLength(50)]
        public string Key { get; set; }

        [Required]
        [StringLength(50)]
        public string Value { get; set; }

        [StringLength(3)]
        public string Type { get; set; }
    }
}
