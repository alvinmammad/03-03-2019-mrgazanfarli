using System;
using System.ComponentModel.DataAnnotations;

namespace Hyna.Models
{
    public class Faq
    {
        public int Id { get; set; }

        [Required]
        public int FaqCategoryId { get; set; }

        [Required]
        [StringLength(250)]
        public string Question { get; set; }

        [Required]
        [StringLength(250)]
        public string Answer { get; set; }

        public FaqCategory FaqCategory { get; set; }
    }
}
