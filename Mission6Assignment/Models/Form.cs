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
        public string Category { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string Lentto { get; set; }
        public string Notes { get; set; }
    }
}