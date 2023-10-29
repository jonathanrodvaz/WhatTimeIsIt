﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatTimeIsIt_VisualStudio
{
    public class TimeZoneService
    {
        public DateTime GetCurrentDateByTimeZone(string timeZoneId)
        {

            var inTimeZone = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
            return TimeZoneInfo.ConvertTime(DateTime.Now, inTimeZone);
        }
        
    }
}
