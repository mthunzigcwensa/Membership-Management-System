using MembershipManagement.Application.Common.Utility;
using MembershipManagement.Application.Services.Interface;
using MembershipManagement.Domain.Entities;
using MembershipManagement.Domain.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Threading.Tasks;

namespace MembershipManagement.Web.Controllers
{
    public class BranchController : Controller
    {
        private readonly IBranchService _branchService;
        private readonly ISealingService _sealingService;
        private readonly IDashboardService _dashboardService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public BranchController(
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            SignInManager<ApplicationUser> signInManager,
            IBranchService branchService,
            ISealingService sealingService,
            IDashboardService dashboardService)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _signInManager = signInManager;
            _branchService = branchService;
            _sealingService = sealingService;
            _dashboardService = dashboardService;
        }

        public IActionResult Index()
        {
            var branches = _branchService.GetAllBranches();
            return View(branches);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Branch obj)
        {
            if (ModelState.IsValid)
            {
                _branchService.CreateBranch(obj);
                return RedirectToAction(nameof(Index));
            }
            return View(obj);
        }

        public IActionResult UpdateBranch(int BranchID)
        {
            Branch branch = _branchService.GetBranchById(BranchID);
            return View(branch);
        }

        [HttpPost]
        public IActionResult UpdateBranch(Branch obj)
        {
            if (ModelState.IsValid)
            {
                _branchService.UpdateBranch(obj);
                return RedirectToAction(nameof(Index));
            }
            return View(obj);
        }

        public IActionResult DeleteBranch(int BranchID)
        {
            Branch branch = _branchService.GetBranchById(BranchID);
            return View(branch);
        }

        [HttpPost]
        public IActionResult DeleteBranch(Branch obj)
        {
            if (ModelState.IsValid)
            {
                _branchService.DeleteBranch(obj.BranchID);
                return RedirectToAction(nameof(Index));
            }
            return View(obj);
        }

        public IActionResult Details(int BranchID)
        {
            Branch branch = _branchService.GetBranchById(BranchID);

            if (branch == null)
            {
                return NotFound();
            }
            return View(branch);
        }

        public ActionResult AddBranchAdmin(int branchId)
        {
            var branchList = _branchService.GetAllBranches()
                                .Select(b => new SelectListItem
                                {
                                    Value = b.BranchID.ToString(),
                                    Text = b.BranchName
                                }).ToList();

            var model = new RegisterVM
            {
                BranchId = branchId,
                BranchList = branchList,
                Password = "M2nzie@emkay",
                ConfirmPassword = "M2nzie@emkay",
                Role = "Branch Manager",
            };

            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> AddBranchAdmin(RegisterVM registerVM)
        {
            ApplicationUser user = new()
            {
                Name = registerVM.Name,
                Email = registerVM.Email,
                PhoneNumber = registerVM.PhoneNumber,
                NormalizedEmail = registerVM.Email.ToUpper(),
                EmailConfirmed = true,
                UserName = registerVM.Email,
                CreatedAt = DateTime.Now,
                BranchId = registerVM.BranchId,
            };

            string defaultPassword = "M2nzie@emkay";
            var result = await _userManager.CreateAsync(user, defaultPassword);

            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, SD.Role_BranchManager);
                return RedirectToAction("Index");
            }

            ModelState.AddModelError(string.Empty, "Failed to create user.");
            return RedirectToAction("Index");
        }

        public ActionResult AddRegularUser(int branchId)
        {
            var branchList = _branchService.GetAllBranches()
                                .Select(b => new SelectListItem
                                {
                                    Value = b.BranchID.ToString(),
                                    Text = b.BranchName
                                }).ToList();

            var model = new RegisterVM
            {
                BranchId = branchId,
                BranchList = branchList,
                Password = "M2nzie@emkay",
                ConfirmPassword = "M2nzie@emkay",
                Role = "Regular User",
            };

            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> AddRegularUser(RegisterVM registerVM)
        {
            ApplicationUser user = new()
            {
                Name = registerVM.Name,
                Email = registerVM.Email,
                PhoneNumber = registerVM.PhoneNumber,
                NormalizedEmail = registerVM.Email.ToUpper(),
                EmailConfirmed = true,
                UserName = registerVM.Email,
                CreatedAt = DateTime.Now,
                BranchId = registerVM.BranchId,
            };

            string defaultPassword = "M2nzie@emkay";
            var result = await _userManager.CreateAsync(user, defaultPassword);

            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, SD.Role_RegularUser);
                return RedirectToAction("Index");
            }

            ModelState.AddModelError(string.Empty, "Failed to create user.");
            return RedirectToAction("Index");
        }

        public ActionResult BranchManagers(int branchId)
        {
            var usersInRole = _userManager.GetUsersInRoleAsync("Branch Manager").Result;
            var branchManager = usersInRole.Where(u => u.BranchId == branchId).ToList();

            return View(branchManager);
        }

        public ActionResult BranchMembers(int branchId)
        {
            var usersInRole = _userManager.GetUsersInRoleAsync("Regular User").Result;
            var branchMembers = usersInRole.Where(u => u.BranchId == branchId).ToList();

            return View(branchMembers);
        }

        public ActionResult BranchSealings(int branchId)
        {
            var sealings = _sealingService.GetAllSealing();
            var branchsealings = sealings.Where(u => u.BranchId == branchId).ToList();

            return View(branchsealings);
        }

        [HttpPost]
        public ActionResult UpdateStatus(Sealing sealing)
        {
            _sealingService.UpdateStatus(sealing.SealingId, SD.StatusApproved);

            return RedirectToAction(nameof(BranchSealings), new { branchId = sealing.SealingId });
        }

        public async Task<IActionResult> GetMemberAndBookingLineChartData()
        {
            return Json(await _dashboardService.GetMemberAndBookingLineChartData());
        }

        [HttpPost]
        public async Task<IActionResult> RemoveBranchManager(string branchManagerId)
        {
            var manager = await _userManager.FindByIdAsync(branchManagerId);
            if (manager != null)
            {
                var result = await _userManager.DeleteAsync(manager);
                if (result.Succeeded)
                {
                    return RedirectToAction(nameof(BranchManagers), new { branchId = manager.BranchId });
                }
                else
                {
                    ModelState.AddModelError("", "Failed to remove branch manager.");
                }
            }
            else
            {
                ModelState.AddModelError("", "Branch manager not found.");
            }

            return RedirectToAction(nameof(BranchManagers));
        }
        public IActionResult Report()
        {
            return View();
        }
    }
}