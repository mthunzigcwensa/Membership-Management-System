using MembershipManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipManagement.Application.Services.Interface
{
    public interface IBranchService
    {
        IEnumerable<Branch> GetAllBranches();
        Branch GetBranchById(int id);
        void CreateBranch(Branch branch);
        void UpdateBranch(Branch branch);
        bool DeleteBranch(int id);
    }
}
