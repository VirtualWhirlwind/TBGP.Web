namespace Core.DB_Interfaces
{
    public interface IStatus : IBaseObj
    {
        string State { get; set; }
    }
}