using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipManagement.Domain.Entities
{
    public class Sealing
    {
        public int SealingId { get; set; }

        [Display(Name = "Sealing Date")]
        [DataType(DataType.Date)]
        public DateTime SealingDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime AppliedByDate { get; set; }

        [Display(Name = "Type")]
        [Required(ErrorMessage = "Sealing type is required")]
        public string SealingType { get; set; }

        [Display(Name = "Member ID")]
        [Required(ErrorMessage = "Member ID is required")]
        public string Id { get; set; }
        [ForeignKey("ApplicationUser")]
        [ValidateNever]
        public ApplicationUser applicationUser { get; set; }

        [Display(Name = "Branch ID")]
        [Required(ErrorMessage = "Branch ID is required")]
        public int BranchId { get; set; }
        [ForeignKey("BranchId")]
        [ValidateNever]
        public Branch branch { get; set; }

        public string Status { get; set; }
    }

}
