using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.UnitiOfWork
{
    public interface IUnitOfWork: IDisposable
    {
        public IRepositoryGroup GroupRepository { get; set; }
        public IRepositoryArchivedTask ArchivedTaskRepository { get; set; }
        public IRepositoryTeam TeamRepository { get; set; }
        public IRepositoryTask TaskRepository { get; set; }
        public IRepositoryUser UserRepository { get; set; }
        public IRepositoryPosition PositionRepository { get; set; }
        void Commit();
    }
}
