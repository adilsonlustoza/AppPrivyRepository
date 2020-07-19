using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using AppPrivy.CrossCutting.Agregation;
using AppPrivy.CrossCutting.Operations;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;

namespace AppPrivy.WebAppMvc.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ILogger<RegisterModel> _logger;
      //  private readonly IEmailSender _emailSender;
        private readonly SendMail _emailSender;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public RegisterModel(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            RoleManager<IdentityRole> roleManager,
            ILogger<RegisterModel> logger,
           // IEmailSender emailSender,
            IWebHostEnvironment webHostEnvironment, 
            SendMail emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _logger = logger;
            _emailSender = emailSender;
            _webHostEnvironment = webHostEnvironment;
        }

        [BindProperty]
        public InputModel Input { get; set; }

       
        [TempData(Key="Mensagem")]
        public string Mensagem { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "Email é requerido.")]
            [EmailAddress(ErrorMessage = "Email inválido")]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Senha é requerida.")]
            [StringLength(100, ErrorMessage = "A {0} deve ter pelo menos {2} e no máximo {1}.", MinimumLength = 3)]
            [DataType(DataType.Password)]
            [Display(Name = "Senha")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirme a senha")]
            [Compare("Password", ErrorMessage = "A senha e a confirmação não são iguais.")]
            public string ConfirmPassword { get; set; }

            [Display(Name = "Papel")]
            public string IdPapel { get; set; }

            [Display(Name = "Grupo")]
            public SelectList Grupos { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            var roles = _roleManager.Roles?.ToList().OrderBy(p => p.Name);
            if (Input == null)
                Input = (InputModel)Activator.CreateInstance(typeof(InputModel));

            Input.Grupos = new SelectList(roles, nameof(IdentityRole.Id), nameof(IdentityRole.Name));
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl =  Url.Content(@"~/Identity/Account/Register");
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            var roles = _roleManager.Roles?.ToList().OrderBy(p => p.Name);
            if (Input == null)
                Input = (InputModel)Activator.CreateInstance(typeof(InputModel));

            Input.Grupos = new SelectList(roles, nameof(IdentityRole.Id), nameof(IdentityRole.Name));

            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = Input.Email, Email = Input.Email };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var papel = await _roleManager.FindByIdAsync(Input.IdPapel);

                    if (papel != null)
                    {
                        var roleExist= await _roleManager.RoleExistsAsync(papel.Name);
                       
                        if (roleExist)
                        {
                            var roleUser = await _userManager.AddToRoleAsync(user, papel.Name);

                            if (roleUser.Succeeded)
                            {
                                var claimRole = new Claim(ClaimTypes.Role, papel.Name);
                                var claimUser = await _userManager.AddClaimAsync(user, new Claim(ClaimTypes.Role, papel.Name));
                                var roleClaim = await _roleManager.FindByNameAsync(papel.Name); 
                                var roleAddClaim = await _roleManager.AddClaimAsync(roleClaim, claimRole); 
                             
                            }
                            
                        }                        

                    }

                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = user.Id, code = code },
                        protocol: Request.Scheme);

                    await _emailSender.SendHtmlFormattedMail( new ContactAgregation()
                    {
                        _path = Path.Combine(_webHostEnvironment.WebRootPath, @"Templates\Email\ConfirmacaoEmail.html"),
                        _email = Input.Email,
                        _name = $"Blog Adilson",
                        _message = $"Por favor, confirme sua conta <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clique aqui</a>.",
                        _subject="Confirmação de e-mail",
                        _to = Input.Email,
                        _body = $"Por favor, confirme sua conta <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clique aqui</a>.",
                        _url = callbackUrl,
                        _phone = "(xx) xxxxx-xx"

                    });

                    //await _emailSender.SendHtmlFormattedMail(Input.Email, "Confirme seu  email",
                    //    $"Por favor, confirme sua conta <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email });
                    }
                    else
                    {
                        Mensagem = string.Format("Foi enviado um e-mail para a confirmação do seu registro em {0}", Input.Email);
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
