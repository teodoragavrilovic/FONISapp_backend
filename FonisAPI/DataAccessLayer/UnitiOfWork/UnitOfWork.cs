using DataAccessLayer.Implementation;
using DataAccessLayer.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.UnitiOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FonisContext context;

        public UnitOfWork(FonisContext context)
        {
            this.context = context;
            GroupRepository = new RepositoryGroup(context);
            ArchivedTaskRepository = new RepositoryArchivedTask(context);
            TeamRepository = new RepositoryTeam(context);
            TaskRepository = new RepositoryTask(context);
            PositionRepository = new RepositoryPosition(context);
            UserRepository = new RepositoryUser(context);   
        }
   
        public IRepositoryGroup GroupRepository { get ; set; }
        public IRepositoryArchivedTask ArchivedTaskRepository { get; set; }
        public IRepositoryTeam TeamRepository { get; set; }
        public IRepositoryTask TaskRepository { get ; set ; }
        public IRepositoryUser UserRepository { get ; set ; }
        public IRepositoryPosition PositionRepository { get ; set ; }

        public void Commit()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
