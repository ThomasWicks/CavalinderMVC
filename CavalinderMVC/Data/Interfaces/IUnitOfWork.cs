using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CavalinderMVC.Controllers.Interfaces
{
    public interface IUnitOfWork
    {
        void BeginTransaction();
        void Commit(bool dispose = true);
        void SaveChanges();
        void Rollback(bool dispose = true);
    }
}
