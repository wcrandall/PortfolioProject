using System.Collections.Generic;
using Portfolio.Models;

namespace Portfolio.Data
{
    public interface IProjectRepo
    {
         IEnumerable<Project> GetAllProjects();
         Project GetProject(int id); 
         
    }
}