using Microsoft.AspNetCore.Hosting;
using MembershipManagement.Application.Common.Interfaces;
using MembershipManagement.Application.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MembershipManagement.Domain.Entities;

namespace MembershipManagement.Application.Services.Implementation
{
    
    public class BranchService : IBranchService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public BranchService(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }

        public void CreateBranch(Branch branch)
        {
            if (branch.Image != null)
            {
                string fileName = Guid.NewGuid().ToString() + Path.GetExtension(branch.Image.FileName);
                string imagePath = Path.Combine(_webHostEnvironment.WebRootPath, @"images\BranchImage");

                using var fileStream = new FileStream(Path.Combine(imagePath, fileName), FileMode.Create);
                branch.Image.CopyTo(fileStream);

                branch.ImageURL = @"\images\BranchImage\" + fileName;
            }
            else
            {
                branch.ImageURL = "https://placehold.co/600x400";
            }

            _unitOfWork.Branch.Add(branch);
            _unitOfWork.Save();
        }

        public bool DeleteBranch(int id)
        {
            try
            {
                Branch? objFromDb = _unitOfWork.Branch.Get(u => u.BranchID == id);
                if (objFromDb is not null)
                {
                    if (!string.IsNullOrEmpty(objFromDb.ImageURL))
                    {
                        var oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, objFromDb.ImageURL.TrimStart('\\'));

                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }
                    _unitOfWork.Branch.Remove(objFromDb);
                    _unitOfWork.Save();

                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<Branch> GetAllBranches()
        {
            return _unitOfWork.Branch.GetAll();
        }

        public Branch GetBranchById(int id)
        {
            return _unitOfWork.Branch.Get(u => u.BranchID == id);
        }

        public void UpdateBranch(Branch branch)
        {
            if (branch.Image != null)
            {
                string fileName = Guid.NewGuid().ToString() + Path.GetExtension(branch.Image.FileName);
                string imagePath = Path.Combine(_webHostEnvironment.WebRootPath, @"images\BranchImage");

                if (!string.IsNullOrEmpty(branch.ImageURL))
                {
                    var oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, branch.ImageURL.TrimStart('\\'));

                    if (System.IO.File.Exists(oldImagePath))
                    {
                        System.IO.File.Delete(oldImagePath);
                    }
                }

                using var fileStream = new FileStream(Path.Combine(imagePath, fileName), FileMode.Create);
                branch.Image.CopyTo(fileStream);

                branch.ImageURL = @"\images\BranchImage\" + fileName;
            }

            _unitOfWork.Branch.Update(branch);
            _unitOfWork.Save();
        }
    }
}
