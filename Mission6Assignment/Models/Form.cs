using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components.Forms;
using System.Reflection.Emit;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Mission6Assignment.Models
{
    public class Form
    {
        [Key]
        [Required]
        public int MovieId { get; set; }
        [ForeignKey("CategoryId")]
        [Required]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [Range(1888, 2025,ErrorMessage = "You must enter a date between 1888 and 2025")]
        public int Year { get; set; }
        public string? Director { get; set; }
        public string? Rating { get; set; }
        [Required]
        public bool Edited { get; set; }
        public string? LentTo { get; set; }
        [Required]
        public bool CopiedToPlex { get; set; }
        public string? Notes { get; set; }
    }
}