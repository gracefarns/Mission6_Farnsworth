using Microsoft.EntityFrameworkCore;

namespace Mission6Assignment.Models
{
    public class FormContext : DbContext
    {
        public FormContext(DbContextOptions<FormContext> options) : base (options)
        {

        }

        public DbSet<Form> Movies { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
