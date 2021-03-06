﻿using System;

namespace ICalendar.ComponentProperties
{
    /// <summary>
    /// Calendar Components: VEVENT, VFREEBUSY;
    /// Value Type: UTC;
    /// Properties Parameters: iana, non-standard, value data type, time zone identifier
    /// </summary>
    public class Dtend : ComponentProperty<DateTime>
    {
        public override string Name => "DTEND";
    }
}