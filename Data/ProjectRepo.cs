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
        public void SaveChanges()
        {
            _projectContext.SaveChanges();
        }
        public void DeleteProject(Project project)
        {
            _projectContext.Projects.Remove(project); 
        }

        public IEnumerable<Project> GetAllProjects()
        {
            return _projectContext.Projects.ToList(); 
        }

        public Project GetProject(int id)
        {
            return _projectContext.Projects.FirstOrDefault(p=>p.Id==id); 
        }

        public void UpdateProject(Project project)
        {
            _projectContext.Projects.Update(project);
        }

        public void CreateProject(Project project)
        {
            _projectContext.Add(project);
        }
    }
}