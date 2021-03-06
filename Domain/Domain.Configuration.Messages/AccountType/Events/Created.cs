﻿using NServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Domain.Configuration.AccountType.Events
{
    public interface Created : IEvent
    {
        Guid AccountTypeId { get; set; }

        String Name { get; set; }

        String DeferralMethod { get; set; }

        Guid? ParentId { get; set; }
    }
}