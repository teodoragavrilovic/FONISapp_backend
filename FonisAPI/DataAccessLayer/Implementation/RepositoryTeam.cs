using DataAccessLayer.Interfaces;
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

        public Task<List<Team>> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Team enthity)
        {
            throw new NotImplementedException();
        }
    }
}
