using AutoMapper;
using Model.DataTransferObject;
using Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = Model.Domain.Task;

namespace Model
{
    public class FonisMapper: Profile
    {
        public FonisMapper()
        {
            CreateMap<Team, TeamDTO>().ReverseMap();
            CreateMap<Position, PositionDTO>().ReverseMap();
            CreateMap<Task, TaskDTO>().ForMember(dest => dest.Team, opt => opt.MapFrom(MapTaskTeam)).ReverseMap();
            CreateMap<User, UserDTO>().ForMember(dest => dest.Position, opt => opt.MapFrom(MapUserPosition)).ReverseMap();
            CreateMap<Group, GroupDTO>().ForMember(dest => dest.ArchivedTasks, opt => opt.MapFrom(MapGroupArchivedTasks)).ReverseMap();
        }

        private List<ArchivedTaskDTO> MapGroupArchivedTasks(Group group, GroupDTO groupDTO)
        {
            var result = new List<ArchivedTaskDTO>();
            if (group.ArchivedTasks != null)
            {
                foreach (var arcTask in group.ArchivedTasks)
                {
                    result.Add(new ArchivedTaskDTO
                    {
                        ArchivedTaskId = arcTask.ArchivedTaskId,
                        Name = arcTask.Name,
                        Description = arcTask.Description,
                        ResponsiblePerson = arcTask.ResponsiblePerson,
                        Team = arcTask.Team
                        
                    });
                }

            }
            return result;
        }

        private PositionDTO MapUserPosition(User user, UserDTO userDTO)
        {
            PositionDTO result = null;
            if (user.Position != null)
            {
                result = new PositionDTO
                {
                    PositionId = user.Position.PositionId,
                    Name = user.Position.Name
                };
            }
            return result;
        }

        private TeamDTO MapTaskTeam(Task task, TaskDTO taskDTO)
        {
            TeamDTO result = null;
            if(task.Team!= null)
            {
                result = new TeamDTO
                {
                    TeamId = task.Team.TeamId,
                    Name = task.Team.Name
                };
            }
            return result;
        }
    }
}
