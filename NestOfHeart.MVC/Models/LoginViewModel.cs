﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NestOfHeart.MVC.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name="用户名")]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "密码")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool IsTeacher { get; set; }
    }
}