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
    public class RepositoryTeam : IRepositoryTeam
    {
        private readonly FonisContext context;

        public RepositoryTeam(FonisContext context)
        {
            this.context = context;
        }
        public void Add(Team enthity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Team enthity)
        {
            throw new NotImplementedException();
        }

        public Task<Team> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Team>> GetAll()
        {
            var result = await context.Teams.ToListAsync();
            return result;
        }

        public void Update(Team enthity)
        {
            throw new NotImplementedException();
        }
    }
}
