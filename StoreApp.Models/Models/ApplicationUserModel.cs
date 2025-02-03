﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Models.Models
{
    public class ApplicationUserModel: IdentityUser
    {
        [Required]
        public string Name { get; set; }
    }
}
