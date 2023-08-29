using Domain.Task.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Task.Port.Repository
{
    public interface ITaskRepository
    {
        WorkTask Create(WorkTask request);
        void DeleteById(long id);
        WorkTask Update(WorkTask request);
    }
}
