using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Project_COVID_19.Views
{
    public class CreateRoleModel
    {
        [Required]
        public String RoleName { get; set; }
    }
}