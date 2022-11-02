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
    public class RepositoryUser : IRepositoryUser
    {
        private readonly FonisContext context;

        public RepositoryUser(FonisContext context)
        {

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

        public Task<List<User>> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(User enthity)
        {
            throw new NotImplementedException();
        }
    }
}
