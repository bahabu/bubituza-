using bubituzagi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace bubituzagi.Controllers
{
    public class UsersController : Controller
    {
        UserManager<ApplicationUser> _userManager;
        SignInManager<ApplicationUser> _signInManager;


        public UsersController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
           
        }
        public IActionResult Index()
        {
            return View(_userManager.Users);
        }
        public IActionResult Create()
        {
            return View();
        }

        // POST: Categories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,UserName,Password,Email,ConfirmPassword,Agreed")] ApplicationUser applicationUser)
        {
            if (ModelState.IsValid)
            {
                if (applicationUser.Agreed == true)
                {
                    _userManager.CreateAsync(applicationUser, applicationUser.Password).Wait();
                    return Redirect("~/");
                }
            }
            return View(applicationUser);
        }

        public IActionResult Login()
        {
            return View();
        }

        // POST: Categories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login( string userName,string password)
        {
            Microsoft.AspNetCore.Identity.SignInResult identityResult;
            if (ModelState.IsValid)
            {

                identityResult = _signInManager.PasswordSignInAsync(userName,password,false,false).Result;
                if (identityResult.Succeeded == true)
                {
                    return Redirect("~/");
                }

            }
            return View();
        }


    }
}
