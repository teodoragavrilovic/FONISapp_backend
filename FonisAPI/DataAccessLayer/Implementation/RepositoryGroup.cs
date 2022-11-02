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
    public class RepositoryGroup : IRepositoryGroup
    {
        private readonly FonisContext context;

        public RepositoryGroup(FonisContext context)
        {

        }
        public void Add(Group enthity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Group enthity)
        {
            throw new NotImplementedException();
        }

        public Task<Group> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Group>> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Group enthity)
        {
            throw new NotImplementedException();
        }
    }
}
