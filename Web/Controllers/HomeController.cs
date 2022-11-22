using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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

        [HttpGet("Index")]
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

        //[HttpPost("Create")]
        //public async Task<IActionResult> Create()
        //{

        //}
    }
}
