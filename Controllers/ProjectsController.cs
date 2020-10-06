using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Data;
using Portfolio.Dtos;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    [Route("api/projects")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly IMapper _mapper; 
        private readonly IProjectRepo _projectRepo; 
        public ProjectsController(IProjectRepo projectRepo, IMapper mapper)
        {
            _mapper = mapper; 
            _projectRepo = projectRepo; 
        }
        
        // GET api/projects/
        [HttpGet]
        public ActionResult<IEnumerable<Project>> GetAllProjects()
        {
            return Ok(_mapper.Map<IEnumerable<ProjectReadDto>>(_projectRepo.GetAllProjects())); 
        }

        //GET api/projects/id
        [HttpDelete]
        public ActionResult DeleteProject(int id)
        {
            var project = _projectRepo.GetProject(id);
            if(project == null)
            {
                return NotFound();    
            }
            _projectRepo.DeleteProject(project);
            _projectRepo.SaveChanges(); 
            return NoContent(); 
        } 

        // GET api/projets/id
        [HttpGet("{id}")]
        public ActionResult<Project> GetProjectById(int id)
        {
            var project = _projectRepo.GetProject(id); 
            if(project == null)
            {
                return NotFound(); 
            }
            return Ok(_mapper.Map<ProjectReadDto>(project)); 
        }

        //POST api/projects/
        [HttpPost]
        public ActionResult<ProjectReadDto> CreateProject(ProjectCreateDto projectCreateDto)
        {
            var project = _mapper.Map<Project>(projectCreateDto); 
            _projectRepo.CreateProject(project);
            _projectRepo.SaveChanges();  
            var projectReadDto = _mapper.Map<ProjectReadDto>(project); 
            return CreatedAtRoute(nameof(GetProjectById), new {id = projectReadDto.Id}, projectReadDto);
        }

        //PUT api/projects/id
        [HttpPut("{id}")]
        public ActionResult Update(int id, ProjectUpdateDto projectUpdateDto)
        {
            var project = _projectRepo.GetProject(id);
            if(project == null)
            {
                return NotFound(); 
            } 
            _mapper.Map(projectUpdateDto, project);
            _projectRepo.UpdateProject(project); 
            _projectRepo.SaveChanges(); 
            return NoContent(); 
        }
        //PATCH api/projects/id
        [HttpPatch("{id}")]
        public ActionResult PartialProjectUpdate(int id, JsonPatchDocument<ProjectUpdateDto> patchDocument)
        {
            var project = _projectRepo.GetProject(id); 
            if(project == null)
            {
                return NotFound(); 
            }
            var projectToPatch = _mapper.Map<ProjectUpdateDto>(project); 
            patchDocument.ApplyTo(projectToPatch, ModelState);
            if(!TryValidateModel(projectToPatch))
            {
                return ValidationProblem(ModelState); 
            }
            _mapper.Map(projectToPatch, project);
            _projectRepo.UpdateProject(project); 
            _projectRepo.SaveChanges(); 
            return NoContent(); 
        }
    }
}