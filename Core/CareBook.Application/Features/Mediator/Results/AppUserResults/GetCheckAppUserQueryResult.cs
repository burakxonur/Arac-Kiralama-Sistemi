﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareBook.Application.Features.Mediator.Results.AppUserResults
{
    public class GetCheckAppUserQueryResult
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; }
        public bool IsExist { get; set; }
    }
}
