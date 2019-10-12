using System;
using static Core.Enums;

namespace Core.DB_Interfaces
{
    public interface IStatus : IBaseObj
    {
        string Name { get ;set; }
        StatusState State { get; set; }
        DateTime LastUpdate { get; set; }
    }
}