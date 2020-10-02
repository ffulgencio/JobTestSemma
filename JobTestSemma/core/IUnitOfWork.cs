using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTestSemma.core
{
    public interface IUnitOfWork: IDisposable
    {
        void Save();
    }
}
