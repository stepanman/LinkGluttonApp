using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LinkGlutton.Mvc.Controllers
{
    public class UsersController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        public UsersController(SignInManager<IdentityUser> manager)
        {
            _manager = manager;
        }

        [HttpGet]
        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async ValueTask<IActionResult> LogIn([Bind("Email", "Password")] Models.LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                IdentityUser user = await _signInManager.UserManager.FindByEmailAsync(model.Email);
                Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(user, model.Password, isPersistent: true, lockoutOnFailure: true);
                if (result.Succeeded)
                    return Redirect("localhost:4020");
                else
                    return 

            }
        }


    }
}
