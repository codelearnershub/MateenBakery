/*
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using BakeryManagementSystem.Interface;
using BakeryManagementSystem.Models;
using BakeryManagementSystem.Models.ViewModel;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BakeryManagementSystem.Controllers
{
    public class AuthController
    {
        public readonly IUserService _userService;
        public readonly IUserRoleService _userRoleService;
        public readonly IRoleService _roleService;
        
        public AuthController(IUserService userService, IUserRoleService userRoleService, IRoleService roleService)
        {
            _userService = userService;
            _userRoleService = userRoleService;
            _roleService = roleService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            _userService.RegisterUser(model);
            return View();
        }


        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {

            _userService.RegisterUser(model);
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel vm)
        {
            User userLogin = new User
            {
                Email = vm.Email,
                Password = vm.Password
            };

            User user = _userService.LoginUser(userLogin);

            if (user == null)
            {
                ViewBag.Message = "Access Denied";
                return View();
            }
            
            var role = _userRoleService.FindRole(user.Id);
            if (role == "Super Admin")
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(ClaimTypes.Role, "Super Admin")

                };

                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var principal = new ClaimsPrincipal(identity);

                var props = new AuthenticationProperties();

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, props);
            }
            else if (role == "Sales Manager")
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(ClaimTypes.Role, "Sales Manager")


                };

                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var principal = new ClaimsPrincipal(identity);

                var props = new AuthenticationProperties();

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, props);
            }
            else if (role == "Store Manager")
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(ClaimTypes.Role, "Store Manager")


                };

                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var principal = new ClaimsPrincipal(identity);

                var props = new AuthenticationProperties();

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, props);
            }


            if (role == "Super Admin")
            {
                return RedirectToAction("ListUser", "SuperAdmin");
            }
            else if (role == "Store Manager")
            {
                return RedirectToAction("Index", "Flock");
            }
            else {
                return NotFound();
            }

        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }
        //The old model of authorization Creating Customer and Admin model seperately having their repositories,services
        //(all with interface) and also their controller.We have foreign key roleId in the user ,so int the service we have 
        //this to assign role to user s in our system. So we ahve this: Role = roleService.FindRole("Customer");

    }
*/
}