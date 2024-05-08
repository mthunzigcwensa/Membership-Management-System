using MembershipManagement.Application.Common.Interfaces;
using MembershipManagement.Application.Services.Interface;
using MembershipManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipManagement.Application.Services.Implementation
{
    public class SealingService : ISealingService
    {
        
        private readonly IUnitOfWork _unitOfWork;
        public SealingService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void CreateSealing(Sealing sealing)
        {
            _unitOfWork.Sealing.Add(sealing);
            _unitOfWork.Save();
        }

        public bool DeleteSealing(int id)
        {
            try
            {
                Sealing? objFromDb = _unitOfWork.Sealing.Get(u => u.SealingId == id);
                _unitOfWork.Sealing.Remove(objFromDb);
                _unitOfWork.Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        
        }

        public IEnumerable<Sealing> GetAllSealing()
        {
            return _unitOfWork.Sealing.GetAll(includeProperties: "applicationUser");
        }

        public Sealing GetSealingById(int id)
        {
            return _unitOfWork.Sealing.Get(u => u.SealingId == id);
        }

        public void UpdateSealing(Sealing sealing)
        {
            _unitOfWork.Sealing.Update(sealing);
            _unitOfWork.Save();
        }

        public void UpdateStatus(int sealingId, string Status)
        {
            var bookingFromDb = _unitOfWork.Sealing.Get(m => m.SealingId == sealingId, tracked: true);
            if (bookingFromDb != null)
            { 
                bookingFromDb.Status = Status;

            }
            _unitOfWork.Save();
        }
    }
}
