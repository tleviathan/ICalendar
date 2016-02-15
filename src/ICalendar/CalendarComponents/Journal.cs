﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ICalendar.ComponentProperties;

namespace ICalendar.CalendarComponents
{
    public class Journal:ICalendarComponent
    {
        public string Name => "VJOURNAL";
        public IEnumerable<IComponentProperty> Properties { get; set; }

        public void Serialize(TextWriter writer)
        {
            throw new NotImplementedException();
        }

        public IComponentProperty Deserialize(string value)
        {
            throw new NotImplementedException();
        }
    }
}