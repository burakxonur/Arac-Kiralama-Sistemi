﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Domain.Entities
{
    public class AppRole
    {
        public int AppRoleID { get; set; }
        public string AppRoleName { get; set; }
        public List<AppUser> AppUser { get; set; }
    }
}
