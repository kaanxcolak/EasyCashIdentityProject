using EasyCashIdentityProject.DtoLayer.Dtos.AppUserDtos;
using EasyCashIdentityProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.PresentationLayer.Controllers
{
    [Authorize]
    public class MyAccountsController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public MyAccountsController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index() //async ile aynı anda birden fazla işlemi asenkron yapmamızı sağlayan keyword
        {
            var result = await _userManager.FindByNameAsync(User.Identity.Name);
            AppUserEditDto appUserEditDto = new AppUserEditDto();
            appUserEditDto.Name = result.Name;
            appUserEditDto.Surname = result.Surname;
            appUserEditDto.PhoneNumber = result.PhoneNumber;
            appUserEditDto.Email = result.Email;
            appUserEditDto.City = result.City;
            appUserEditDto.District = result.District;
            appUserEditDto.ImageUrl = result.ImageUrl;
            return View(appUserEditDto);
        }

        [HttpPost]
        public async Task<IActionResult> Index(AppUserEditDto appUserEditDto)
        {
            if (appUserEditDto.Password == appUserEditDto.ConfirmPassword)
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);
                user.PhoneNumber = appUserEditDto.PhoneNumber;
                user.Surname = appUserEditDto.Surname;
                user.City = appUserEditDto.City;
                user.District = appUserEditDto.District;
                user.Name = appUserEditDto.Name;
                user.ImageUrl = "test";
                user.Email = appUserEditDto.Email;
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, appUserEditDto.Password); //Veritabanına şifreyi hashleyerek göndermiş olucaz
            }
            return View();

        }
    }
}
