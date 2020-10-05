using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Data;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    [Route("api/projects")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly IProjectRepo _projectRepo; 
        public ProjectsController(IProjectRepo projectRepo)
        {
            _projectRepo = projectRepo; 
        }
        // GET api/projects/
        [HttpGet]
        public ActionResult<IEnumerable<Project>> GetAllProjects()
        {
            var projects = _projectRepo.GetAllProjects(); 
            return Ok(projects); 
        }

        // GET api/projets/id
        [HttpGet("{id}")]
        public ActionResult<Project> GetProjectById(int id)
        {
            var project = _projectRepo.GetProject(id); 
            return Ok(project); 
        }
    }
}