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
    public class RepositoryArchivedTask : IRepositoryArchivedTask
    {
        private readonly FonisContext context;

        public RepositoryArchivedTask(FonisContext context)
        {

        }
        public void Add(ArchivedTask enthity)
        {
            throw new NotImplementedException();
        }

        public void Delete(ArchivedTask enthity)
        {
            throw new NotImplementedException();
        }

        public Task<ArchivedTask> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ArchivedTask>> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(ArchivedTask enthity)
        {
            throw new NotImplementedException();
        }
    }
}
