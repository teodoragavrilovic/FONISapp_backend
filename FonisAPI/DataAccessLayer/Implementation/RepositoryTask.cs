using DataAccessLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Implementation
{
    public class RepositoryTask : IRepositoryTask
    {
        private readonly FonisContext context;

        public RepositoryTask(FonisContext context)
        {

            this.context = context;
        }
        public void Add(Model.Domain.Task enthity)
        {
            enthity.Team = context.Teams.Find(enthity.Team.TeamId);
            try
            {
                context.Add(enthity);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(Model.Domain.Task enthity)
        {
            throw new NotImplementedException();
        }

        public Task<Model.Domain.Task> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Model.Domain.Task>> GetAll()
        {
            var result = await context.Tasks.ToListAsync();
            foreach (var task in result)
            {
                task.Team = context.Teams.Find(task.TaskId);
            }
            return result;
        }

        public void Update(Model.Domain.Task enthity)
        {
            enthity.Team = context.Teams.Find(enthity.Team.TeamId);
            try
            {
                context.Update(enthity);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
