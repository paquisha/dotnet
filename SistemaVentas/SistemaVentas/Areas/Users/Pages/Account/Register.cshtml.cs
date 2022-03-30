using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaVentas.Areas.Users.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVentas.Areas.Users.Pages.Account
{
    public class RegisterModel : PageModel
    {
        public void OnGet()
        {
        }
        [BindProperty]
        public InputModel Input { get; set; }
        public class InputModel : InputModelRegister
        {
            public IFormFile AvatarImage { get; set; }
            [TempData]
            public string ErrorMessage { get; set; }
        }
    }
}
