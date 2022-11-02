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
            CreateMap<Task, TaskDTO>().ForMember(dest => dest.Team, opt => opt.MapFrom(MapTaskTeam)).ReverseMap();
            CreateMap<User, UserDTO>().ForMember(dest => dest.Position, opt => opt.MapFrom(MapUserPosition)).ReverseMap();
            CreateMap<Group, GroupDTO>().ForMember(dest => dest.ArchivedTasks, opt => opt.MapFrom(MapGroupArchivedTasks)).ReverseMap();
        }

        private List<ArchivedTaskDTO> MapGroupArchivedTasks(Group group, GroupDTO groupDTO)
        {
            throw new NotImplementedException();
        }

        private List<PositionDTO> MapUserPosition(User user, UserDTO userDTO)
        {
            throw new NotImplementedException();
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
