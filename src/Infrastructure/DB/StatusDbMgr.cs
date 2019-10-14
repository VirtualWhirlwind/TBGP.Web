using Core.DB;
using Core.DB_Interfaces;
using Infrastructure.DB_Model;
using System.Linq;

namespace Infrastructure.DB
{
    public partial class DbMgr : IDbMgr
    {
        public void SaveStatus(IStatus save)
        {
            if (save.Id != 0) { Context.Update(save); }
            else { Context.Add(save); }
            Context.SaveChanges();
        }

        public IStatus GetStatus()
        {
            var Result = Context.Statuses.SingleOrDefault(c => c.Name == Status.DEFAULT_NAME);
            if (Result == null) { Result = new Status(); }
            return Result;
        }
    }
}