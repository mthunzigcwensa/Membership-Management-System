using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembershipManagement.Domain.Entities
{
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Branch
    {
        [Key]
        public int BranchID { get; set; }

        [Required(ErrorMessage = "Branch name is required")]
        [MaxLength(100, ErrorMessage = "Branch name cannot exceed 100 characters")]
        public string BranchName { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [MaxLength(255, ErrorMessage = "Address cannot exceed 255 characters")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Country is required")]
        [MaxLength(100, ErrorMessage = "Country cannot exceed 100 characters")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Province is required")]
        [MaxLength(100, ErrorMessage = "Province cannot exceed 100 characters")]
        public string Province { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [MaxLength(15, ErrorMessage = "Phone number cannot exceed 15 characters")]
        [Phone(ErrorMessage = "Invalid phone number format")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Email address is required")]
        [EmailAddress(ErrorMessage = "Invalid email address format")]
        [MaxLength(100, ErrorMessage = "Email address cannot exceed 100 characters")]
        public string Email { get; set; }
        [NotMapped]
        public IFormFile? Image { get; set; }

        [MaxLength(255, ErrorMessage = "Image URL cannot exceed 255 characters")]
        [ValidateNever]
        public string ImageURL { get; set; }

        [Display(Name = "Member Count")]
        public int? MemberCount { get; set; }

        [Display(Name = "Admin Count")]
        public int? AdminCount { get; set; }
    }

}
