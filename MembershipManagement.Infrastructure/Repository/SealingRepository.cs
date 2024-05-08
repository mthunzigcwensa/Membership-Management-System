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
    internal class SealingRepository : Repository<Sealing>, ISealingRepository
    {
        private readonly ApplicationDbContext _db;

        public SealingRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Sealing entity)
        {
            _db.Sealings.Update(entity);
        }
    }
}
