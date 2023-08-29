using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Task.Model.Constants
{
    public static class TaskConstant
    {
        public const string TASK_NOT_FOUND_MESSAGE_ERROR = "No se encontro una tarea con el id %s";
        public const string CURRENT_TASK_NOT_ALLOW_TO_DELETE = "La tarea %s no se puede eliminar porque tiene usuarios asignados";
    }
}
