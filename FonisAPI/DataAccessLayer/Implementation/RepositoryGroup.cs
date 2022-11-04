using DataAccessLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Implementation
{
    public class RepositoryGroup : IRepositoryGroup
    {
        private readonly FonisContext context;

        public RepositoryGroup(FonisContext context)
        {
            this.context = context;
        }
        public void Add(Group enthity)
        {
            try
            {
                //foreach(ArchivedTask arcTask in context.ArchivedTasks)
                //{
                //    context.Add(arcTask);
                //}
                context.Add(enthity);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(Group enthity)
        {
            throw new NotImplementedException();
        }

        public Task<Group> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Group>> GetAll()
        {
            var result = await context.Groups.Include(e => e.ArchivedTasks).ToListAsync();
        
            return result;
        }

        public void Update(Group enthity)
        {
            throw new NotImplementedException();
        }
    }
}
