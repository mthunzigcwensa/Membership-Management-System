using MembershipManagement.Application.Common.Interfaces;
using MembershipManagement.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipManagement.Infrastructure.Repository
{

    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public IApplicationUserRepository User { get; private set; }
        public IBranchRepository Branch { get; private set; }
        public ISealingRepository Sealing { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Branch = new BranchRepository(db);
            User = new ApplicationUserRepository(_db);
            Sealing = new SealingRepository(db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
