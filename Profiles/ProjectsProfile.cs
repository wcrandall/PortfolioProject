using Portfolio.Dtos;
using Portfolio.Models;
using AutoMapper; 

namespace Portfolio.Profiles
{
    public class ProjectsProfile:Profile
    {
        public ProjectsProfile()
        {
            //<source, target>
            CreateMap<Project, ProjectReadDto>();
            CreateMap<ProjectCreateDto, Project>(); 
            CreateMap<Project, ProjectReadDto>(); 

        }
    }
}