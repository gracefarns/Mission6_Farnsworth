using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components.Forms;
using System.Reflection.Emit;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission6Assignment.Models
{
    public class Form
    {
        [Key]
        [Required]
        public int MovieId { get; set; }
        [Required]
        public string CategoryId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
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