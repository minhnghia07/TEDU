using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TEDU.Admin.Services;
using TEDU.ViewModels.System.Users;

namespace TEDU.Admin.Controllers
{
    public class UserController : Controller
    {
        public readonly IUserApiClient _userApiClient;
        public UserController(IUserApiClient userApiClient)
        {
            _userApiClient = userApiClient;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        } 

        [HttpPost]
        public async Task<IActionResult> Login(LoginRequest request)
        {
            if (!ModelState.IsValid)
                return View(ModelState);

            var token = await _userApiClient.Authenticate(request);
            return View(token);
        }
    }
}
