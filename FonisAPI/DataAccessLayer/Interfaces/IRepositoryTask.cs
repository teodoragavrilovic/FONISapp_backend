using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Domain;
using Task = Model.Domain.Task;

namespace DataAccessLayer.Interfaces
{
    public interface IRepositoryTask: IRepository<Task>
    {
    }
}
