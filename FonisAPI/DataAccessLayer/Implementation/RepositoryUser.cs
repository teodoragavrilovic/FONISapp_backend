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
    public class RepositoryUser : IRepositoryUser
    {
        private readonly FonisContext context;

        public RepositoryUser(FonisContext context)
        {
            this.context = context;
        }
        public void Add(User enthity)
        {
            throw new NotImplementedException();
        }

        public void Delete(User enthity)
        {
            throw new NotImplementedException();
        }

        public Task<User> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<User>> GetAll()
        {
            var result = await context.Users.ToListAsync();
            foreach (var user in result)
            {
                user.Position = context.Positions.Find(user.PositionId);
            }
            return result;
        }

        public void Update(User enthity)
        {
            throw new NotImplementedException();
        }
    }
}
