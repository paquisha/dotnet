using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SistemasVentas.Areas.Users.Models;
using SistemasVentas.Data;
using SistemasVentas.Library;

namespace SistemasVentas.Areas.Users.Pages.Account
{
    public class RegisterModel : PageModel
    {

        public SignInManager<IdentityUser> _signInManager;
        public UserManager<IdentityUser> _userManager;
        public RoleManager<IdentityRole> _roleManager;
        private LUsersRoles _usersRoles;
        private static InputModel _dataInput;
        private ApplicationDbContext _context;
        private Uploadimage _uploadimage;
        private IWebHostEnvironment _environment;

        public RegisterModel( UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager, 
            RoleManager<IdentityRole> roleManager,
            ApplicationDbContext context,
            IWebHostEnvironment environment)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _usersRoles = new LUsersRoles();
            _context = context;
            _environment = environment;
            _uploadimage = new Uploadimage();
        }
        public void OnGet()
        {
            if(_dataInput != null)
            {
                Input = _dataInput;
                Input.rolesLista = _usersRoles.getRoles(_roleManager);
                Input.AvatarImage = null;
            }
            else
            {
                Input = new InputModel
                {
                    rolesLista = _usersRoles.getRoles(_roleManager)
                };

            }

        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel: InputModelRegister
        {
            public IFormFile AvatarImage { get; set; }

            [TempData]
            public string ErrorMessage { get; set; }

            public List<SelectListItem> rolesLista { get; set; }
        }

        public async Task<IActionResult> OnPost()
        {
            if(await SaveAsync())
            {
                return Redirect("/Users/Users?area=Users");
            }
            else
            {
                return Redirect("/Users/Register");
            } 
        }

        public async Task<bool> SaveAsync()
        {
            _dataInput = Input;
            var valor = false;
            if (ModelState.IsValid)
            {
                var userList = _userManager.Users.Where(u => u.Email.Equals(Input.Email)).ToList();
                if (userList.Count.Equals(0))
                {
                    var strategy = _context.Database.CreateExecutionStrategy();
                    await strategy.ExecuteAsync(async () =>
                    {
                        using (var transaction = _context.Database.BeginTransaction())
                        {
                            try
                            {
                                var user = new IdentityUser
                                {
                                    UserName = Input.Email,
                                    Email = Input.Email,
                                    PhoneNumber = Input.PhoneNumber
                                };
                                var result = await _userManager.CreateAsync(user, Input.Password);
                                if (result.Succeeded)
                                {
                                    await _userManager.AddToRoleAsync(user, Input.Role);
                                    var dataUser = _userManager.Users.Where(u => u.Email.Equals(Input.Email)).ToList().Last();
                                    var imageByte = await _uploadimage.ByteAvatarImageAsync(Input.AvatarImage, _environment, "images/images/default.png");
                                    var t_user = new TUsers
                                    {
                                        Name = Input.Name,
                                        LastName = Input.LastName,
                                        CI = Input.CI,
                                        Email = Input.Email,
                                        idUser = dataUser.Id,
                                        Image = imageByte,
                                    };
                                    await _context.AddAsync(t_user);
                                    _context.SaveChanges();

                                    transaction.Commit();
                                    _dataInput = null;
                                    valor = true;
                                }
                                else
                                {
                                    foreach(var item in result.Errors)
                                    {
                                        _dataInput.ErrorMessage = item.Description;
                                    }
                                    valor = false;
                                    transaction.Rollback();
                                }
                            }
                            catch(Exception ex)
                            {
                                _dataInput.ErrorMessage = ex.Message;
                                transaction.Rollback();
                                valor = false;
                            }
                        }
                    });
                }
                else
                {
                    _dataInput.ErrorMessage = $"El {Input.Email} ya esta registrado";
                    valor = false;
                }
            }
            else
            {
                foreach (var modelState in ModelState.Values)
                {
                    foreach(var error in modelState.Errors)
                    {
                        _dataInput.ErrorMessage += error.ErrorMessage;
                    }
                }
                valor = false;
            }

            return valor;
        }

    }
}
