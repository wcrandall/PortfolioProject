using System.Collections.Generic;
using Portfolio.Models;

namespace Portfolio.Data
{
    public interface IProjectRepo
    {
         IEnumerable<Project> GetAllProjects();
         Project GetProject(int id); 
         void DeleteProject(Project project); 
         void SaveChanges(); 

         void UpdateProject(Project project); 
         void CreateProject(Project project); 
         
    }
}