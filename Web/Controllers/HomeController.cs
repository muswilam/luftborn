using Core;
using Core.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            var genders = await _unitOfWork.Users.GetGendersLookupAsync();

            var users = await _unitOfWork.Users.GetAllAsync();

            var userViewModel = new UserViewModel
            {
                Genders = genders,
                Users = users
            };

            return View(userViewModel);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(NewUserModel newUser)
        {
            try
            {
                var user = new User
                {
                    Name = newUser.Name,
                    GenderId = newUser.GenderId,
                    CreatedDate = DateTime.UtcNow
                };

                await _unitOfWork.Users.AddAsync(user);

                await _unitOfWork.CommitAsync();

                return Json(new { isSuccess = true, id = user.Id, createdDate = user.CreatedDate.ToString("dd MMM yyyy") });
            }
            catch (Exception ex)
            {
                return Json(new { isSuccess = false, result = ex.Message.ToString() });
            }
        }

        [HttpPost("Remove")]
        public async Task<IActionResult> Remove(RemoveUserModel removeUser)
        {
            try
            {
                var user = await _unitOfWork.Users.GetAsync(removeUser.Id);

                if(user is null)
                    return Json(new { isSuccess = false, result = "User is not found!"});

                _unitOfWork.Users.Remove(user);

                await _unitOfWork.CommitAsync();

                return Json(new { isSuccess = true});
            }
            catch (Exception ex)
            {
                return Json(new { isSuccess = false, result = ex.Message.ToString() });
            }
        }
    }
}
