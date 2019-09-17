using Core.DB_Interfaces;

namespace Core.DB
{
    public partial interface IDbMgr
    {
        void SaveStatus(IStatus save);
        IStatus GetStatus();
    }
}