using Domain.Task.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Task.Port.Dao
{
    public interface ITaskDao
    {
        WorkTask GetById(long id);
        IEnumerable<WorkTask> GetAll();
        IEnumerable<WorkTask> GetByIds(List<long> tasksIds);
    }
}
