using Core.DB_Interfaces;
using static Core.Enums;

namespace Infrastructure.DB_Model
{
    public class Status : BaseObj, IStatus
    {
        public StatusState State { get; set; }
    }
}