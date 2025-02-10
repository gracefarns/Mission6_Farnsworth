using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components.Forms;
using System.Reflection.Emit;

namespace Mission6Assignment.Models
{
    public class Form
    {
        [Key]
        [Required]
        public int MovieID { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string DirectorF { get; set; }
        [Required]
        public string DirectorL { get; set; }
        [Required]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string? Lentto { get; set; }
        public string? Notes { get; set; }
    }
}