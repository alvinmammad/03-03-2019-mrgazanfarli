using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hyna.Models
{
    public class Blog
    {
        public int Id { get; set; }

        [StringLength(1000)]
        public string Slug { get; set; }

        [Required]
        [StringLength(1000)]
        public string Title { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public int AuthorId { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        [StringLength(500)]
        public string Desc { get; set; }

        [Required]
        [StringLength(250)]
        public string Photo { get; set; }

        [Required, MinLength(250)]
        [Column(TypeName = "text")]
        public string Text { get; set; }

        public Author Author { get; set; }
        public Category Category { get; set; }
    }
}
