using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.User.Model.Constants
{
    public static class UserConstant
    {
        public const string TASK_NOT_FOUND_MESSAGE_ERROR = "No se encontro una tarea con el id {0}";
        public const string CURRENT_USER_NOT_ALLOW_TO_DO_TASKS = "El total de horas ({0}) en tareas supera las horas permitidas";
        public const string CURRENT_USER_NOT_ALLOW_TO_DELETE = "El usuario {0} no se puede eliminar porque tiene tareas pendientes por finalizar";
    }
}
