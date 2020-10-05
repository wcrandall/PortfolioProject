using System.Collections.Generic;
using System.Linq;
using Portfolio.Models;

namespace Portfolio.Data
{
    public class ProjectRepo:IProjectRepo
    {
        private readonly List<Project> _projects = new List<Project>(){
            new Project(){
                Title="Studier",
                Url="givemejob.com", 
                Description="helps study", 
                Id=1
            }, 
            new Project(){
                Title="Portfolio", 
                Url="lolLIEKTHATSGONNAHAPPEN.com",
                Description="jokes are good", 
                Id=2
            }
        };
        public IEnumerable<Project> GetAllProjects()
        {
            return _projects; 
        }

        public Project GetProject(int id)
        {
            return _projects.SingleOrDefault(p=>p.Id == id); 
        }
    }
}