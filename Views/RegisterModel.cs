using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Project_COVID_19.Utilities;

namespace Project_COVID_19.Models
{
    public class RegisterModel
    {

        [Required]
        public string Name { get; set; }

        [Required, StringLength(80)]
        public string LastName { get; set; }

        [Required]
        public string IdType { get; set; }

        [Required]
        public string Identification { get; set; }
                
        [Required]
        [EmailAddress]
        [Remote(action: "IsEmailInUse", controller:"Account")]
        [ValidEmailDomain(allowedDomain: "gmail.com", ErrorMessage="Email domain must be gmail.com")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password",
            ErrorMessage = "Password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

    }
}