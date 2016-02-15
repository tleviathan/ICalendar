﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICalendar.ComponentProperties
{
    public interface IPropertyParameter
    {
        string Name { get; }

        string Value { get; set; }
    }
}