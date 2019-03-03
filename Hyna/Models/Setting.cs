using System;
using System.ComponentModel.DataAnnotations;

namespace Hyna.Models
{
    public class Setting
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Logo { get; set; }

        [Required]
        [StringLength(50)]
        public string Phone { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(200)]
        public string Address { get; set; }

        public string Facebook { get; set; }

        public string Instagram { get; set; }

        public string Youtube { get; set; }

        [Required]
        [StringLength(50)]
        public string Lat { get; set; }

        [Required]
        [StringLength(50)]
        public string Lng { get; set; }
    }
}
