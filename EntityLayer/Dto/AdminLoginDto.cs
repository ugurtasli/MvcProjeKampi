﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Dto
{
    public class AdminLoginDto
    {
        public string AdminName { get; set; }
        public string AdminUserName { get; set; }

        public string AdminPassword { get; set; }

        public int RoleId { get; set; }
    }
}
