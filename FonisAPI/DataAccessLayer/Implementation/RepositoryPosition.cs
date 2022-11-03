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
    public class RepositoryPosition : IRepositoryPosition
    {
        private readonly FonisContext context;

        public RepositoryPosition(FonisContext context)
        {

            this.context = context;
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

        public async Task<List<Position>> GetAll()
        {
            var result = await context.Positions.ToListAsync();
            return result;
        }

        public void Update(Position enthity)
        {
            throw new NotImplementedException();
        }
    }
}
