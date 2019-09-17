using Core.DB_Interfaces;

namespace Infrastructure.DB_Model
{
    public class Status : BaseObj, IStatus
    {
        protected string _State = null;
        public string State { get => _State ?? "Offline"; set => _State = value; }
    }
}