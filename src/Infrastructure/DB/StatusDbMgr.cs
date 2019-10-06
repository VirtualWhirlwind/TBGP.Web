using Core.DB;
using Core.DB_Interfaces;
using Infrastructure.DB_Model;
using MongoDB.Driver;

namespace Infrastructure.DB
{
    public partial class DbMgr : IDbMgr
    {
        public void SaveStatus(IStatus save)
        {
            if (save.Id != null)
            {
                Context.Statuses.FindOneAndReplace(Filter(save.Id.ToString()), (Status)save);
            }
            else
            {
                Context.Statuses.InsertOne((Status)save);
            }
        }

        public IStatus GetStatus()
        {
            var Result = Context.Statuses.Find(Filter()).FirstOrDefault();
            if (Result == null) { Result = new Status(); }
            return Result;
        }
    }
}