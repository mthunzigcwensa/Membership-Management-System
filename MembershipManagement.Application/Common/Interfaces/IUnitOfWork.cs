using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipManagement.Application.Common.Interfaces
{
    public interface IUnitOfWork
    {
        IApplicationUserRepository User { get; }
        IBranchRepository Branch { get; }
        ISealingRepository Sealing { get; }
        void Save();
    }
}
