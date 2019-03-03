using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Hyna.Models
{
    public class FaqCategory
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public List<Faq> Faqs { get; set; }
    }
}
