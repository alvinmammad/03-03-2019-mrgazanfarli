using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hyna.Models
{
    public class Service
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Order By")]
        public int OrderBy { get; set; }

        [StringLength(50)]
        public string Slug { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(250)]
        public string Icon { get; set; }

        [Required]
        [StringLength(250)]
        public string Photo { get; set; }

        [Required]
        [StringLength(100)]
        public string Desc { get; set; }

        [Required, MinLength(250)]
        [Column(TypeName = "text")]
        public string Text { get; set; }

        [StringLength(250)]
        public string Pdf { get; set; }

        [StringLength(250)]
        public string Doc { get; set; }
    }
}
