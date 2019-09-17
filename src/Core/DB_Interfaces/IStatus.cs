namespace Core.DB_Interfaces
{
    public enum StatusState { Offline, Online, Maintenance }
    public interface IStatus : IBaseObj
    {
        StatusState State { get; set; }
    }
}