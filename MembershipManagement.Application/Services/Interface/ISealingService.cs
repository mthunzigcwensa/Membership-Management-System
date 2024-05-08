using MembershipManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipManagement.Application.Services.Interface
{
    public interface ISealingService
    {
        IEnumerable<Sealing> GetAllSealing();
        Sealing GetSealingById(int id);
        void CreateSealing(Sealing sealing);
        void UpdateSealing(Sealing sealing);
        void UpdateStatus(int Id, string Status);
        bool DeleteSealing(int id);
    }
}
