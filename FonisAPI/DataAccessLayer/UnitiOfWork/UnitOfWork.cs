using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.UnitiOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
       // private readonly FonisContext context;

        public UnitOfWork(/*FonisContext context*/)
        {
           
        }
   
        public IRepositoryGroup GroupRepository { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IRepositoryArchivedTask ArchivedTaskRepository { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IRepositoryTeam TeamRepository { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IRepositoryTask TaskRepository { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IRepositoryUser UserRepository { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IRepositoryPosition PositionRepository { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Commit()
        {
            //context.SaveChanges();
        }

        public void Dispose()
        {
            //context.Dispose();
        }
    }
}
