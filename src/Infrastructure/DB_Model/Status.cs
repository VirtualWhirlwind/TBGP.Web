using Core.DB_Interfaces;

namespace Infrastructure.DB_Model
{
    public class Status : BaseObj, IStatus
    {
        public StatusState State { get; set; }
    }
}