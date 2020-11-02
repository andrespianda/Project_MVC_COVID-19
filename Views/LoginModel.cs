using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project_COVID_19.Models
{
    public class LoginModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Recordar Usuario")]
        public bool RememberMe { get; set; }
    }
}