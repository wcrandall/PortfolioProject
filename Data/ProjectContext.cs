using Microsoft.EntityFrameworkCore;
using Portfolio.Models;

namespace Portfolio.Data
{
    public class ProjectContext:DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> opt):base(opt)
        {
            
        }

        public DbSet<Project> Projects { get; set; }
    }
}