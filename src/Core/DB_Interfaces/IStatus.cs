using static Core.Enums;

namespace Core.DB_Interfaces
{
    public interface IStatus : IBaseObj
    {
        StatusState State { get; set; }
    }
}