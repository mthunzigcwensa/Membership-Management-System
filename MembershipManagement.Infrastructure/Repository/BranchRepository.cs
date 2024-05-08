using MembershipManagement.Application.Common.Interfaces;
using MembershipManagement.Domain.Entities;
using MembershipManagement.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipManagement.Infrastructure.Repository
{
    public class BranchRepository : Repository<Branch>, IBranchRepository
    {
        private readonly ApplicationDbContext _db;

        public BranchRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Branch entity)
        {
            _db.Branches.Update(entity);
        }
    }
}
