using MembershipManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipManagement.Application.Common.Interfaces
{
    public interface IBranchRepository : IRepository<Branch>
    {

        void Update(Branch entity);

    }
}
