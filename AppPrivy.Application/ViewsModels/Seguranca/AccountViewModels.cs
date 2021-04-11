using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CompareAttribute = System.ComponentModel.DataAnnotations.CompareAttribute;

namespace Appointment.Application.ViewsModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Codigo")]
        public string Code { get; set; }

        public string ReturnUrl { get; set; }

        [Display(Name = "Relembrar este navegador ?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class UserToken
    {
        
        [Required(ErrorMessage ="{0} é requerido")]
        [DataType(DataType.EmailAddress)]
        [FromHeader]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} é requerido")]
        [DataType(DataType.Password)]
        [FromHeader]
        public string Password { get; set; }   
        

        [JsonIgnore]
        public string Token { get; set; }

        [JsonIgnore]
        [DataType(DataType.Date)]
        public DateTime? Expiration { get; set; }

    }


    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail é requerido!")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password, ErrorMessage = "Senha é requerida!")]
        [Display(Name = "Senha")]
        
        public string Password { get; set; }


        [JsonIgnore]
        [Display(Name = "Relembrar?")]
        public bool RememberMe { get; set; }

        [JsonIgnore]  
        [Required]
        [Display(Name = "Papel")]
        public string IdPapel { get; set; }

        [JsonIgnore]
        [NotMapped]
        public SelectList SelectListGroup { get; set; }




    }

    public class RegisterViewModel
    {

        [Display(Name = "Papel")]
        public string IdPapel { get; set; }

        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail é requerido!")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "A {0} deve possuir {2} no mínimo.", MinimumLength = 6)]
        [DataType(DataType.Password, ErrorMessage = "Senha é requerida!")]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar")]
        [Compare("Password", ErrorMessage = "A senha e a confirmação são diferntes.")]
        public string ConfirmPassword { get; set; }

        [NotMapped]
        public SelectList SelectListGroup { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail é requerido!")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "A {0} deve possuir {2} no mínimo.", MinimumLength = 6)]
        [DataType(DataType.Password, ErrorMessage = "Senha é requerida!")]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [DataType(DataType.Password, ErrorMessage = "Confirmação é requerida!")]
        [Display(Name = "Confirmar")]
        [Compare("Password", ErrorMessage = "A senha e a confirmação não são iguais.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail é requerido!")]
        public string Email { get; set; }
    }
}
