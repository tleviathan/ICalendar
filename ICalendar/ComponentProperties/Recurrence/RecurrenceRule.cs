﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICalendar.ComponentProperties.Recurrence
{
    public class RecurrenceRule:IComponentProperty, ISerialize
    {
        /*

        Calendar Components: VEVENT, VTODO, VJOURNAL -- STANDARD, DAYLIGHT subcomponents

        Value Type: RECUR

        Properties Parameters: iana, non-standard

        */

        public string Name => "RRULE";
        public void Serialize()
        {
            throw new NotImplementedException();
        }

        public IComponentProperty Deserialize()
        {
            throw new NotImplementedException();
        }

        //fix this impllement value type recur
        public int Value { get; }
    }
}