using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.Concrete.UnitOfWork
{
    public interface IUnitOfWork
    { 
        void Commit();
    }
}