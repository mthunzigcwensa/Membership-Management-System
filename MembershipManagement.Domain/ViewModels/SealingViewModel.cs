using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipManagement.Domain.ViewModels
{
    public class SealingViewModel
    {
        public int SealingId { get; set; }
        public DateTime SealingDate { get; set; }
        public DateTime AppliedByDate { get; set; }
        public string SealingType { get; set; }
        public string MemberId { get; set; }
        public int BranchId { get; set; }
        public string Status { get; set; }

        // ApplicationUser details
        public string UserName { get; set; }
        public string Email { get; set; }
        // Add more ApplicationUser properties as needed
    }
}
