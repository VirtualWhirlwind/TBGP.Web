using System;
using Core.DB_Interfaces;
using static Core.Enums;

namespace Infrastructure.DB_Model
{
    public class Status : BaseObj, IStatus
    {
        protected DateTime _LastUpdated = DateTime.Now;

        public StatusState State { get; set; }

        public DateTime LastUpdate
        {
            get => _LastUpdated;
            set => _LastUpdated = value;
        }
    }
}