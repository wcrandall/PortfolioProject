using System.Collections.Generic;
using System.Linq;
using Portfolio.Models;

namespace Portfolio.Data
{
    public class ProjectRepo:IProjectRepo
    {
        private readonly ProjectContext _projectContext;
        public ProjectRepo(ProjectContext projectContext)
        {
            _projectContext = projectContext;    
        } 

        public IEnumerable<Project> GetAllProjects()
        {
            return _projectContext.Projects.ToList(); 
        }

        public Project GetProject(int id)
        {
            return _projectContext.Projects.SingleOrDefault(p=>p.Id==id); 
        }
    }
}