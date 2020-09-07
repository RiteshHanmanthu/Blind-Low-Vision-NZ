using EmployeeManagement.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


namespace LowVision.Controllers
{
    public class AccountController: Controller  
    {



        [HttpGet]
        [AllowAnonymous]
        public IActionResult AccessDenied()
        {

            return View();
        }

        // Other actions
    }
}
