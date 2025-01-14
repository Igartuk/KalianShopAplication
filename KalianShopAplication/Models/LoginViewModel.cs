﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalianShopApplication.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "логин")]
        public string UserName { get; set; }

        [Required]
        [UIHint("password")]
        [Display(Name ="Пароль")]
        public string Password { get; set; }

        [Display(Name = "Запомнить меня?")]
        public bool RememberMe { get; set; }
    }
}
