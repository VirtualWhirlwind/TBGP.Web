using System;
using System.ComponentModel.DataAnnotations.Schema;
using Core.DB_Interfaces;
using static Core.Enums;

namespace Infrastructure.DB_Model
{
    [Table("status")]
    public class Status : BaseObj, IStatus
    {
        #region Fields
        public const string DEFAULT_NAME = "Main";
        protected string _Name = DEFAULT_NAME;
        protected StatusState _State = StatusState.Offline;
        protected DateTime _LastUpdate = DateTime.Now;
        #endregion

        #region Properties
        public string Name
        {
            get => _Name;
            set => _Name = value ?? DEFAULT_NAME;
        }

        public StatusState State
        {
            get => _State;
            set
            {
                if (_State != value)
                {
                    _State = value;
                    LastUpdate = DateTime.Now;
                }
            }
        }

        public DateTime LastUpdate
        {
            get => _LastUpdate;
            set => _LastUpdate = value;
        }
        #endregion
    }
}