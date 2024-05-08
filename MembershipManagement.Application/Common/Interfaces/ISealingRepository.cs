using MembershipManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipManagement.Application.Common.Interfaces
{
    public interface ISealingRepository : IRepository<Sealing>
    {

        void Update(Sealing entity);
    }
}
