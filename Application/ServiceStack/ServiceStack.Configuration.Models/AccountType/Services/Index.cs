﻿using Demo.Domain.Configuration.AccountType;
using Demo.Library.Queries;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Application.ServiceStack.Configuration.AccountType.Services
{
    [Api("Configuration")]
    [Route("/configuration/account-type", "GET")]
    public class Index : PagedQuery<Responses.Index>
    {
        public Guid? Id { get; set; }

        public String Name { get; set; }

        public String DeferralMethod { get; set; }

        public Guid? ParentId { get; set; }
    }
}