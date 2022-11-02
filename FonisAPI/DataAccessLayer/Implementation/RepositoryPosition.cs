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
    public class RepositoryPosition : IRepositoryPosition
    {
        private readonly FonisContext context;

        public RepositoryPosition(FonisContext context)
        {

        }
        public void Add(Position enthity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Position enthity)
        {
            throw new NotImplementedException();
        }

        public Task<Position> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Position>> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Position enthity)
        {
            throw new NotImplementedException();
        }
    }
}
